using UnityEngine;


namespace MemoTools { 
    public abstract class LifetimeEvent: MonoBehaviour
    {
        [SerializeField] private LifetimeEventType lifetimeEvent;

        protected abstract void OnEvent();

        private void Awake()
        {
            if (lifetimeEvent == LifetimeEventType.OnAwake) OnEvent();
        }

        private void Start()
        {
            if (lifetimeEvent == LifetimeEventType.OnStart) OnEvent();
        }

        private void OnEnable()
        {
            if (lifetimeEvent == LifetimeEventType.OnEnable) OnEvent();
        }

        private void OnDisable()
        {
            if (lifetimeEvent == LifetimeEventType.OnDisable) OnEvent();
        }

        private void OnDestroy()
        {
            if (lifetimeEvent == LifetimeEventType.OnDestroy) OnEvent();
        }
    }
}
