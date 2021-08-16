

namespace MemoTools {
    public class FloatEventArgs : System.EventArgs
    {
        public FloatEventArgs(float value)
        {
            Value = value;
        }

        public float Value { get; set; }
    }
}
