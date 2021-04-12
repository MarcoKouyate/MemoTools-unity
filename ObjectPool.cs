using UnityEngine;
using System.Collections.Generic;


namespace MemoTools { 
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _size;

        private void Awake()
        {
            _pooledObjects = new Queue<GameObject>();

            GameObject parent = new GameObject();
            parent.name = $"{ _prefab.name} Clones";
            _prefab.SetActive(false);

            for(int i = 0; i<_size; i++)
            {
                GameObject pooledObject = Instantiate(_prefab, parent.transform);
                pooledObject.SetActive(false);
                _pooledObjects.Enqueue(pooledObject);
            }

            _prefab.SetActive(true);
        }

        public GameObject Take(Vector3 position, Quaternion rotation)
        {
            GameObject obj = _pooledObjects.Dequeue();
            _pooledObjects.Enqueue(obj);
            

            if (!obj) return null; 

            obj.transform.position = position;
            obj.transform.rotation = rotation;
            obj.SetActive(true);
            return obj;
        }

        private Queue<GameObject> _pooledObjects;
    }
}
