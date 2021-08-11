using UnityEngine;


namespace MemoTools { 
    public class BillboardDisplay : MonoBehaviour
    {
        [Tooltip("The component looks for the main camera if no camera is assigned")]
        [SerializeField] private Camera _camera;

        private void Awake()
        {
            _transform = transform;
            if (!_camera) _camera = Camera.main;
        }

        private void LateUpdate()
        {
            _transform.LookAt(_transform.position + _camera.transform.forward);
        }

        private Transform _transform;
    }
}
