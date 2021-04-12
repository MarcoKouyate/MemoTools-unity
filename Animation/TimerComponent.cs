using UnityEngine;


namespace MemoTools { 
    public abstract class TimerComponent : MonoBehaviour
    {
        #region Show In Inspector
        [SerializeField] private float[] _intervals;
        #endregion

        /// <summary>
        /// The method is called at the end of each timer.
        /// </summary>
        /// <param name="index">Index of the current timer in timers list</param>
        protected abstract void OnTimeEnd(int index);


        #region Unity Cycle
        /// <summary>
        /// Override DoAwake() instead.
        /// </summary>
        private void Awake()
        {
            if (_intervals.Length > 0) ResetTimer();

            DoAwake();
        }


        /// <summary>
        /// Override DoUpdate() instead.
        /// </summary>
        private void Update()
        {
            CheckTimer();
            DoUpdate();
        }
        #endregion

        #region Unity Cycle Substitutes
        protected virtual void DoAwake()
        {

        }

        protected virtual void DoUpdate()
        {

        }
        #endregion

        private void CheckTimer()
        {
            if (_intervals.Length == 0) return;

            if (_timer.OnTimeEnd)
            {
                NextTimer();
                OnTimeEnd(_index);
            }
        }

        #region Private Methods
        private void NextTimer()
        {
            NextInterval();
            ResetTimer();
        }

        private void NextInterval()
        {
            _index++;
            if (_index >= _intervals.Length) _index = 0;
        }

        private void ResetTimer()
        {
            _timer = new MemoTools.Timer(_intervals[_index], true);
        }
        #endregion

        #region Private Variables
        private Timer _timer;
        private int _index;
        #endregion
    }
}
