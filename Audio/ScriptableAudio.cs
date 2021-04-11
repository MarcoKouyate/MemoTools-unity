using UnityEngine;


namespace MemoTools {
    [CreateAssetMenu(menuName ="MemoTools/Audio/ScriptableAudio", fileName ="Scriptable Audio")]
    public class ScriptableAudio : ScriptableObject
    {
        public AudioClip clip;
        [Range(0f,1f)] public float volume = 1f;
    }
}
