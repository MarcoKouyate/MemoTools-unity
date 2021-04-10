using UnityEngine;
using System;


namespace MemoTools { 
    public class TriggerAnimation : MonoBehaviour
    {
        [SerializeField] private string animationName;
        [SerializeField] private Animator _animator;

        public event EventHandler OnAnimationEnd;

        private void Awake()
        {
            _animationId = Animator.StringToHash(animationName);
        }

        public void Trigger()
        {
            _animator.Play(_animationId);
        }

        public void AnimationEnd()
        {
            OnAnimationEnd?.Invoke(this, EventArgs.Empty);
        }

        private int _animationId;
    }
}
