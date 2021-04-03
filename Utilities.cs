using UnityEngine;

namespace MemoTools { 
    public class Utilities
    {
        static public bool IsVectorActive(Vector2 vector, float threshold)
        {
            return (Mathf.Abs(vector.x) > threshold || Mathf.Abs(vector.y) > threshold);
        }

        static public void Swap(ref Vector3 vector1, ref Vector3 vector2)
        {
            Vector3 temp = vector1;
            vector1 = vector2;
            vector2 = temp;
        }
    }
 }
