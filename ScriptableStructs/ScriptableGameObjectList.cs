using UnityEngine;


namespace MemoTools { 
    [CreateAssetMenu(menuName ="MemoTools/Scriptable Structs/GameObjectList", fileName ="Game Object List")]
    public class ScriptableGameObjectList : ScriptableObject
    {
        public GameObject[] elements;

        public GameObject GetRandomElement()
        {
            int randomIndex = Random.Range(0, elements.Length);
            return elements[randomIndex];
        }
    }
}
