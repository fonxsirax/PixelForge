using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace PixelForge.Characters3D
{
    /// <summary>
    /// Drives a rigged model straight from the clips in a Character3DData, without an
    /// AnimatorController asset. Two layers mixed at the root:
    ///   0 - locomotion: idle / walk / run blended by speed (always running, loops)
    ///   1 - action:     one-shot clip (attack, interact, hurt...) faded in over locomotion
    ///
    /// The graph is evaluated manually so poses can be stepped at a fixed rate (e.g. 12 fps):
    /// at sprite resolution a smooth 60 fps pose change reads as "3D", stepped reads as pixel art.
    /// </summary>
    public sealed class ModelAnimationGraph : IDisposable
    {
        private const float ActionFade = 0.1f;
        private const int LocomotionPort = 0;
        private const int ActionPort = 1;
        private const int IdlePort = 0, WalkPort = 1, RunPort = 2;

        private readonly Character3DData _data;
        private readonly float _stepInterval;

        private PlayableGraph _graph;
        private AnimationMixerPlayable _root;
        private AnimationMixerPlayable _locomotion;
        private AnimationClipPlayable _idle, _walk, _run;

        private AnimationClipPlayable _action;
        private float _actionLength;
        private Action _onActionFinished;

        private float _speed;
        private float _pendingTime;

        public bool IsPlayingAction => _action.IsValid();

        public ModelAnimationGraph(Animator animator, Character3DData data)
        {
            _data = data;
            _stepInterval = data.animationFps > 0f ? 1f / data.animationFps : 0f;

            _graph = PlayableGraph.Create($"{animator.name}.ModelAnimation");
            _graph.SetTimeUpdateMode(DirectorUpdateMode.Manual);

            var output = AnimationPlayableOutput.Create(_graph, "Animation", animator);
            _root = AnimationMixerPlayable.Create(_graph, 2);
            output.SetSourcePlayable(_root);

            _locomotion = AnimationMixerPlayable.Create(_graph, 3);
            _graph.Connect(_locomotion, 0, _root, LocomotionPort);
            _root.SetInputWeight(LocomotionPort, 1f);

            _idle = ConnectLoop(data.idle, IdlePort);
            _walk = ConnectLoop(data.walk, WalkPort);
            _run = ConnectLoop(data.run, RunPort);

            ApplyLocomotionWeights();
            _graph.Play();
            _graph.Evaluate(0f);
        }

        /// <summary>Current ground speed in units/s; drives the idle/walk/run blend.</summary>
        public void SetSpeed(float speed) => _speed = speed;

        /// <summary>
        /// Plays a clip once over the locomotion layer. Returns false (and never calls back)
        /// when the clip is missing, so callers don't lock the character waiting for it.
        /// </summary>
        public bool PlayAction(AnimationClip clip, Action onFinished = null)
        {
            if (clip == null) return false;

            StopAction(notify: false);
            _action = AnimationClipPlayable.Create(_graph, clip);
            _action.SetApplyFootIK(true);
            _graph.Connect(_action, 0, _root, ActionPort);
            _root.SetInputWeight(ActionPort, 0f);
            _actionLength = clip.length;
            _onActionFinished = onFinished;
            return true;
        }

        /// <summary>Advance by real elapsed time. Poses only change on whole animation steps.</summary>
        public void Tick(float deltaTime)
        {
            if (!_graph.IsValid()) return;

            if (_stepInterval <= 0f)
            {
                Step(deltaTime);
                return;
            }

            _pendingTime += deltaTime;
            if (_pendingTime < _stepInterval) return;

            float step = Mathf.Floor(_pendingTime / _stepInterval) * _stepInterval;
            _pendingTime -= step;
            Step(step);
        }

        private void Step(float dt)
        {
            ApplyLocomotionWeights();
            UpdateAction();
            _graph.Evaluate(dt);
            if (_action.IsValid() && _action.GetTime() >= _actionLength) StopAction(notify: true);
        }

        private void UpdateAction()
        {
            if (!_action.IsValid()) return;

            float t = (float)_action.GetTime();
            float fadeIn = Mathf.Clamp01(t / ActionFade);
            float fadeOut = Mathf.Clamp01((_actionLength - t) / ActionFade);
            float weight = Mathf.Min(fadeIn, fadeOut);
            _root.SetInputWeight(ActionPort, weight);
            _root.SetInputWeight(LocomotionPort, 1f - weight);
        }

        private void StopAction(bool notify)
        {
            if (!_action.IsValid()) return;

            _graph.Disconnect(_root, ActionPort);
            _action.Destroy();
            _action = default;
            _root.SetInputWeight(ActionPort, 0f);
            _root.SetInputWeight(LocomotionPort, 1f);

            var callback = _onActionFinished;
            _onActionFinished = null;
            if (notify) callback?.Invoke();
        }

        private void ApplyLocomotionWeights()
        {
            // Missing run clip: the walk clip covers the whole range, just played faster.
            bool hasRun = _run.IsValid();
            float walkSpeed = Mathf.Max(0.01f, _data.walkSpeed);
            float runSpeed = hasRun ? Mathf.Max(walkSpeed + 0.01f, _data.runSpeed) : float.MaxValue;

            float idleW, walkW, runW;
            if (_speed <= walkSpeed)
            {
                walkW = Mathf.Clamp01(_speed / walkSpeed);
                idleW = 1f - walkW;
                runW = 0f;
            }
            else
            {
                runW = Mathf.Clamp01((_speed - walkSpeed) / (runSpeed - walkSpeed));
                walkW = 1f - runW;
                idleW = 0f;
            }

            SetWeight(_idle, IdlePort, idleW);
            SetWeight(_walk, WalkPort, walkW);
            SetWeight(_run, RunPort, runW);

            // Scale playback with actual speed so feet roughly match the ground.
            if (_walk.IsValid()) _walk.SetSpeed(Mathf.Clamp(_speed / Mathf.Max(0.01f, _data.walkClipSpeed), 0.6f, 2.5f));
            if (hasRun) _run.SetSpeed(Mathf.Clamp(_speed / Mathf.Max(0.01f, _data.runClipSpeed), 0.6f, 1.8f));
        }

        private void SetWeight(AnimationClipPlayable playable, int port, float weight)
        {
            if (playable.IsValid()) _locomotion.SetInputWeight(port, weight);
        }

        private AnimationClipPlayable ConnectLoop(AnimationClip clip, int port)
        {
            if (clip == null) return default;
            var playable = AnimationClipPlayable.Create(_graph, clip);
            playable.SetApplyFootIK(true);
            _graph.Connect(playable, 0, _locomotion, port);
            return playable;
        }

        public void Dispose()
        {
            if (_graph.IsValid()) _graph.Destroy();
        }
    }
}
