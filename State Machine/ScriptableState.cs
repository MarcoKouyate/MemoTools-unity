using UnityEngine;


namespace MemoTools {

    public class ScriptableState<StateType, MachineType> : ScriptableState 
        where StateType:ScriptableState<StateType, MachineType>
        where MachineType: StateMachine<StateType, MachineType>
    {
        protected MachineType Machine { get; private set; }

        public void Plug(MachineType machine)
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
