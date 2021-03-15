using UnityEngine;

namespace MemoTools { 
    public class Utilities
    {
        static public bool IsVectorActive(Vector2 vector, float threshold)
        {
            return (vector.x > threshold || vector.y > threshold);
        }
    }
 }
