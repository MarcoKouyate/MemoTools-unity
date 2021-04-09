using UnityEngine;


namespace MemoTools { 

    [CreateAssetMenu(menuName ="MemoTools/Objective/CompleteAtIntCount", fileName ="Objective Completed At Int Count")]
    public class CompleteObjectiveAtIntCount : Objective
    {
        [Header("Int Comparizon")]
        [SerializeField] private ScriptableInt currentValue;
        [SerializeField] private CompareEnum comparizon;
        [SerializeField] private int goalValue;

        protected override bool IsSelfCompleted {get
            {
                int current = currentValue.value;
                bool result;

                switch(comparizon)
                {
                    case CompareEnum.Equal: 
                        result = (current == goalValue);
                        break;
                    case CompareEnum.LessThan:
                        result = current < goalValue;
                        break;
                    case CompareEnum.MoreThan:
                        result = current > goalValue;
                        break;
                    default:
                        result = false;
                        break;
                }

                return result;
            }
        }

       

    }
}
