// Flat, banded lighting for 3D characters that are rendered into a tiny pixel-art RenderTexture.
// The light is a fixed direction (not a scene light) so every character is lit the same way no
// matter where its stage is, and smooth PBR gradients collapse into a few readable color bands.
Shader "PixelForge/ToonModel"
{
    Properties
    {
        [MainTexture] _BaseMap ("Texture", 2D) = "white" {}
        [MainColor] _BaseColor ("Color", Color) = (1, 1, 1, 1)
        _LightDir ("Light Direction (world)", Vector) = (-0.45, 0.8, -0.5, 0)
        _Bands ("Light Bands", Range(1, 6)) = 3
        _ShadowTint ("Shadow Tint", Color) = (0.5, 0.48, 0.68, 1)
    }

    SubShader
    {
        Tags { "RenderType" = "Opaque" "RenderPipeline" = "UniversalPipeline" "Queue" = "Geometry" }

        Pass
        {
            Name "ForwardToon"
            Tags { "LightMode" = "UniversalForward" }
            ZWrite On
            ZTest LEqual
            Cull Back

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            TEXTURE2D(_BaseMap);
            SAMPLER(sampler_BaseMap);

            CBUFFER_START(UnityPerMaterial)
                float4 _BaseMap_ST;
                half4 _BaseColor;
                float4 _LightDir;
                half _Bands;
                half4 _ShadowTint;
            CBUFFER_END

            struct Attributes
            {
                float4 positionOS : POSITION;
                float3 normalOS : NORMAL;
                float2 uv : TEXCOORD0;
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float3 normalWS : TEXCOORD0;
                float2 uv : TEXCOORD1;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                o.positionCS = TransformObjectToHClip(v.positionOS.xyz);
                o.normalWS = TransformObjectToWorldNormal(v.normalOS);
                o.uv = TRANSFORM_TEX(v.uv, _BaseMap);
                return o;
            }

            half4 frag(Varyings i) : SV_Target
            {
                half3 albedo = SAMPLE_TEXTURE2D(_BaseMap, sampler_BaseMap, i.uv).rgb * _BaseColor.rgb;

                // Half-Lambert, then quantized into hard bands.
                float ndl = dot(normalize(i.normalWS), normalize(_LightDir.xyz)) * 0.5 + 0.5;
                float bands = max(1.0, _Bands);
                float level = saturate(floor(ndl * bands) / max(1.0, bands - 1.0));

                half3 color = albedo * lerp(_ShadowTint.rgb, half3(1, 1, 1), level);
                return half4(color, 1);
            }
            ENDHLSL
        }
    }
}
