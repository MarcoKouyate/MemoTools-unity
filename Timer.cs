using UnityEngine;


namespace MemoTools { 
    public class Timer
    {
        public Timer(float interval, bool repeat)
        {
            _interval = interval;
            _repeat = repeat;
            Reset();
        }

        public float Remaining { get => _nextTime - Time.time; }

        public float Elapsed { get => Time.time - _startTime; }

        public bool IsExpired
        { 
            get => Remaining <= 0;
        }

        public void Reset()
        {
            _startTime = Time.time;
            _nextTime = _startTime + _interval;
            _active = true;
        }

        public bool OnTimeEnd
        {
            get
            {
                if (_active && IsExpired)
                {
                    _active = false;
                    if (_repeat) Reset();
                    return true;
                }
                return false;
            }
        }

        public void Expire()
        {
            _nextTime = Time.time;
        }

        private bool _active;
        private bool _repeat;
        private float _startTime;
        private float _nextTime;
        private float _interval;
    }
}
