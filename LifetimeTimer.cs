using UnityEngine;


namespace MemoTools {
    public class LifetimeTimer : MonoBehaviour
    {
        [SerializeField] private float _duration;

        public Timer Timer { get; private set; }

        private void Awake()
        {
            Timer = new Timer(_duration, false);
        }

        private void Update()
        {
            if (Timer.OnTimeEnd) Destroy(gameObject);
        }

    }
}
