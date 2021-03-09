using UnityEngine;

namespace MemoUnity {

    /// <summary>
    /// This Monobehaviour ensures that only one gameObject attached with this component exists in the scene. 
    /// The generic type should be child of SingletonMonoBehaviour
    /// It requires to override InitAwake() and DestroyOnLoad
    /// </summary>
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        /// <summary>
        /// Determine if Singleton should be destroyed when changing scenes 
        /// </summary>
        protected abstract bool DestroyOnLoad { get; }

        /// <summary>
        /// Use this property to access the singleton instance.  
        /// </summary>
        public T Instance { get; private set; }


        /// <summary>
        /// The Singleton Monobehaviour already uses Awake() for creating itself and shouldn't be override. 
        /// It is recommended to use InitAwake() for code to execute at Awake time.
        /// </summary>
        protected void Awake()
        {
            if(Instance == null)
            {
                Instance = (T) this;
                if (!DestroyOnLoad)
                {
                    DontDestroyOnLoad(this);
                }
                InitAwake();
            } else
            {
                Destroy(gameObject);
            }
        }

        /// <summary>
        /// InitAwake is used as an Awake() method for SingletonMonoBehaviours
        /// </summary>
        protected abstract void InitAwake();

    }
}
