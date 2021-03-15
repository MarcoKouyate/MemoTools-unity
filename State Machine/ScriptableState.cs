using UnityEngine;


namespace MemoTools {

    public class ScriptableState<StateType> : ScriptableState where StateType:ScriptableState
    {
        protected GenericStateMachine<StateType> Machine { get; private set; }

        public void Plug(GenericStateMachine<StateType> machine)
        {
            Machine = machine;
        }
    }


    public abstract class ScriptableState : ScriptableObject
    {
        /// <summary>
        /// This method is called once when entering the state. 
        /// </summary>
        public virtual void EnterState()  { }

        /// <summary>
        /// This method is called once when leaving the state. 
        /// </summary>
        public virtual void ExitState() { }

        public virtual void UpdateState() { }

        public virtual void FixedUpdateState() { }
    }

}
