using UnityEngine;

namespace MemoTools { 
    public class Utilities
    {
        static public bool IsVectorActive(Vector2 vector, float threshold)
        {
            return (Mathf.Abs(vector.x) > threshold || Mathf.Abs(vector.y) > threshold);
        }
    }
 }
