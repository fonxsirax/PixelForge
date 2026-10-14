// Draws a character's pixel RenderTexture inside the 2D world (2D Renderer, SRPDefaultUnlit pass).
// Alpha is hard-cut and a 1-pixel outline is added around the silhouette, computed in texel space
// so it always lands exactly on the pixel grid.
Shader "PixelForge/PixelSprite"
{
    Properties
    {
        [MainTexture] _MainTex ("Render", 2D) = "black" {}
        [MainColor] _Tint ("Tint", Color) = (1, 1, 1, 1)
        _OutlineColor ("Outline Color", Color) = (0.08, 0.06, 0.1, 1)
        [Toggle] _Outline ("Outline", Float) = 1
        _AlphaCutoff ("Alpha Cutoff", Range(0.01, 1)) = 0.5
        _Posterize ("Color Steps per Channel (0 = off)", Range(0, 32)) = 0
    }

    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "RenderPipeline" = "UniversalPipeline" "IgnoreProjector" = "True" }
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite Off
        Cull Off

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            TEXTURE2D(_MainTex);
            SamplerState pf_point_clamp_sampler;

            CBUFFER_START(UnityPerMaterial)
                float4 _MainTex_TexelSize;
                half4 _Tint;
                half4 _OutlineColor;
                half _Outline;
                half _AlphaCutoff;
                half _Posterize;
            CBUFFER_END

            struct Attributes
            {
                float4 positionOS : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
                o.uv = v.uv;
                return o;
            }

            half Alpha(float2 uv)
            {
                return SAMPLE_TEXTURE2D(_MainTex, pf_point_clamp_sampler, uv).a;
            }

            half4 frag(Varyings i) : SV_Target
            {
                half4 c = SAMPLE_TEXTURE2D(_MainTex, pf_point_clamp_sampler, i.uv);
                if (c.a >= _AlphaCutoff)
                {
                    if (_Posterize > 1) c.rgb = round(c.rgb * _Posterize) / _Posterize;
                    return half4(c.rgb * _Tint.rgb, _Tint.a);
                }

                if (_Outline > 0.5)
                {
                    float2 t = _MainTex_TexelSize.xy;
                    half n = max(max(Alpha(i.uv + float2(t.x, 0)), Alpha(i.uv - float2(t.x, 0))),
                                 max(Alpha(i.uv + float2(0, t.y)), Alpha(i.uv - float2(0, t.y))));
                    if (n >= _AlphaCutoff) return half4(_OutlineColor.rgb, _OutlineColor.a * _Tint.a);
                }

                discard;
                return 0;
            }
            ENDHLSL
        }
    }
}
