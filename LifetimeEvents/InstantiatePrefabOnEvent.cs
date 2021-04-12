using UnityEngine;


namespace MemoTools { 
    public class InstantiatePrefabOnEvent : LifetimeEvent
    {
        [SerializeField] private ObjectPool _pool;
        [SerializeField] private Transform _spawn;

        void OnApplicationQuit()
        {
            _isQuitting = true;
        }

        protected override void OnEvent()
        {
            if (_isQuitting) return;
            _pool.Take(_spawn.position, _spawn.transform.rotation);
        }

        private bool _isQuitting = false;
    }
}
