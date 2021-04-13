using UnityEngine;


namespace MemoTools { 
    public class SpriteJauge : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _max;
        [SerializeField] private float _offset;
        [SerializeField] private MemoTools.ScriptableInt _tracked;

        private void Awake()
        {
            elements = new GameObject[_max];

            for (int i = 0; i < _max; i++) {
                GameObject instance = Instantiate(_prefab, transform);
                float position = (instance.transform.localScale.x + _offset);
                instance.transform.Translate(Vector2.right * i * position * transform.localScale);
                elements[i] = instance;
            }
        }

        private void Update()
        {
            SetValue(_tracked.value);
        }

        public void SetValue(int value)
        {
            foreach (GameObject element in elements)
            {
                element.SetActive(false);
            }

            Debug.Log(value);

            if (value > elements.Length) value = elements.Length;

            for (int i = 0; i < value; i++)
            {
                
                elements[i].SetActive(true);
            }
        }


        private GameObject[] elements;
    }
}
