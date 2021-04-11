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

        public bool IsExpired
        { 
            get => Time.time > _nextTime;
        }

        public void Reset()
        {
            _nextTime = Time.time + _interval;
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

        private bool _active;
        private bool _repeat;
        private float _nextTime;
        private float _interval;
    }
}
