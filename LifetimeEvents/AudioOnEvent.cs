using UnityEngine;


namespace MemoTools { 
    public class AudioOnEvent : LifetimeEvent
    {
        [SerializeField] private ScriptableAudio _sfx;
        [SerializeField] private MemoTools.AudioPlayer _audioPlayer;

        protected override void OnEvent()
        {
            _audioPlayer.Play(_sfx);
        }
    }
}
