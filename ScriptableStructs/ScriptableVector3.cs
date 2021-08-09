using UnityEngine;


namespace MemoTools
{
    [CreateAssetMenu(menuName = "MemoTools/Scriptable Structs/Vector3", fileName = "Scriptable Vector3")]
    public class ScriptableVector3 : ScriptableObject
    {
        public Vector3 value;
    }
}