using UnityEngine;


namespace MemoTools { 
    public class AudioOnEvent : LifetimeEvent
    {
        [SerializeField] private ScriptableAudio _sfx;

        protected override void OnEvent()
        {
            AudioManager.Instance.Play(_sfx);
        }
    }
}
