using UnityEngine;


namespace MemoTools {
    public class CountOnEvent : LifetimeEvent
    {
        [SerializeField] private MemoTools.ScriptableInt counter;
        [SerializeField] private int increment;

        protected override void OnEvent()
        {
            counter.value += increment;
        }
    }
}
