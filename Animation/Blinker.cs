using UnityEngine;


namespace MemoTools { 
    public abstract class Blinker : TimerComponent
    {
        protected override void OnTimeEnd(int index)
        {
            Switch();
        }

        private void Switch()
        {
            _highlight = !_highlight;
            if (_highlight)
            {
                BlinkOn();
            }
            else
            {
                BlinkOff();
            }
        }

        private void OnEnable()
        {
            _highlight = false;
        }


        protected abstract void BlinkOff();
        protected abstract void BlinkOn();

        private bool _highlight;
    }
}
