using UnityEngine;


namespace MemoTools {
    public class CountOnEvent : MonoBehaviour
    {
        [SerializeField] private MemoTools.ScriptableInt counter;
        [SerializeField] private LifetimeEvent lifetimeEvent;
        [SerializeField] private int increment;

        private void Awake()
        {
            if (lifetimeEvent == LifetimeEvent.OnAwake) counter.value += increment;
        }

        private void Start()
        {
            if (lifetimeEvent == LifetimeEvent.OnStart) counter.value += increment;
        }

        private void OnEnable()
        {
            if (lifetimeEvent == LifetimeEvent.OnEnable) counter.value += increment;
        }

        private void OnDisable()
        {
            if (lifetimeEvent == LifetimeEvent.OnDisable) counter.value += increment;
        }

        private void OnDestroy()
        {
            if(lifetimeEvent == LifetimeEvent.OnDestroy) counter.value += increment;
        }

    }
}
