using UnityEngine;


namespace MemoTools { 
    public class InstantiatePrefabOnEvent : LifetimeEvent
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _spawn;

        void OnApplicationQuit()
        {
            _isQuitting = true;
        }

        protected override void OnEvent()
        {
            if (_isQuitting) return;

            Instantiate(_prefab, _spawn.position, _spawn.transform.rotation);
        }

        private bool _isQuitting = false;
    }
}
