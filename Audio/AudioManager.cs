using UnityEngine;


namespace MemoTools {
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : SingletonMonoBehaviour<AudioManager>
    {
        [SerializeField] private bool _dontDestroyOnLoad;
        protected override bool DestroyOnLoad { get => !_dontDestroyOnLoad; }

        protected override void InitAwake()
        {
            _source = GetComponent<AudioSource>();
        }

        #region Load
        public void Load(AudioClip clip)
        {
            _source.clip = clip;
        }

        public void Load(ScriptableAudio audio)
        {
            _source.volume = audio.volume;
            Load(audio.clip);
        }
        #endregion


        #region Play
        public void Play()
        {
            _source.Play();
        }

        public void Play(AudioClip clip)
        {
            Load(clip);
            Play();
        }

        public void Play(ScriptableAudio audio)
        {
            Load(audio);
            Play();
        }
        #endregion

        private AudioSource _source;
    }
}
