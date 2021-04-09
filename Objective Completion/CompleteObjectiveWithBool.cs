using UnityEngine;


namespace MemoTools { 


    [CreateAssetMenu(menuName ="MemoTools/Objective/CompleteWithBool", fileName ="Objective Completed With Bool")]
    public class CompleteObjectiveWithBool : Objective
    {
        [Header("Boolean check")]
        public bool completed;
        protected override bool IsSelfCompleted { get => completed; }
    }
}
