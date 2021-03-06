using UnityEngine;

namespace MemoTools { 

    public abstract class StateMachine<StateType, MachineType> : GenericStateMachine<StateType> 
        where StateType : ScriptableState<StateType, MachineType>
        where MachineType: StateMachine<StateType, MachineType>
    {
        protected override void PlugState()
        {
            CurrentState.Plug((MachineType) this);
        }
    }

    public abstract class GenericStateMachine<StateType> : MonoBehaviour where StateType : ScriptableState

    {
        #region Show In Inspector
        [SerializeField] 
        private StateType StartingState;
        #endregion


        #region Properties
        public StateType CurrentState { get; private set; }
        public StateType LastState { get; private set; }

        #endregion


        #region Unity Cycle
        /// <summary>
        /// Start is already used by the StateMachine base class. 
        /// It is recommanded to override AwakeMachine() instead in order to execute code at Start Time.
        /// </summary>
        protected void Start()
        {
            StartMachine();
            SwitchTo(StartingState);
        }

        /// <summary>
        /// Update is already used by the StateMachine base class. 
        /// It is recommanded to override UpdateMachine() instead in order to execute code at Update time.
        /// </summary>
        private void Update()
        {
            UpdateMachine();
            CurrentState.UpdateState();
        }


        /// <summary>
        /// FixedUpdate() is already used by the StateMachine base class. 
        /// It is recommanded to override FixedUpdateMachine() instead in order to execute code at FixedUpdate time.
        /// </summary>
        private void FixedUpdate()
        {
            FixedUpdateMachine();
            CurrentState.FixedUpdateState();
        }
        #endregion


        #region Delegates
        /// <summary>
        /// This method is called before at Awake time before switching to the first state.
        /// </summary>
        protected virtual void StartMachine()
        {

        }

        /// <summary>
        /// This method is called each frame before called the Update() of the current state.
        /// </summary>
        protected virtual void UpdateMachine()
        {

        }

        /// <summary>
        /// This method is called before each FixedUpdate() of the current state.
        /// </summary>
        protected virtual void FixedUpdateMachine()
        {

        }
        #endregion


        #region State Transition
        public void SwitchTo(StateType nextStep)
        {
            if(CurrentState != null)
            {
                CurrentState.ExitState();
                LastState = CurrentState;
            }

            CurrentState = nextStep;
            PlugState();
            CurrentState.EnterState();
        }

        protected abstract void PlugState();

        #endregion
    }

}
