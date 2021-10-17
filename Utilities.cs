using UnityEngine;
using System.Linq;
using System.Collections.Generic;

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

        static public bool CompareTags(GameObject other, string[] tags)
        {
            foreach (string tag in tags)
            {
                if (other.CompareTag(tag)) return true;
            }

            return false;
        }
    }


    public static class GameObjectUtils
    {
        public static List<GameObject> SortByDistance(this List<GameObject> objects, Vector3 mesureFrom)
        {
            return objects.OrderBy(x => Vector3.Distance(x.transform.position, mesureFrom)).ToList();
        }
    }
}
