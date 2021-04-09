using UnityEngine;


namespace MemoTools {

    public enum CompareType { AND, OR }

    [CreateAssetMenu(menuName = "MemoTools/Objective/Objective", fileName = "Self Completed Objective")]
    public class Objective : ScriptableObject
    {
        #region Show In Inspector
        [SerializeField] private Objective[] subObjectives;
        [SerializeField] private CompareType compareType;
        #endregion

        #region Properties
        protected virtual bool IsSelfCompleted { get => true; }

        public bool IsCompleted { get => IsSelfCompleted && AreSubObjectivesCompleted; }

        public bool AreSubObjectivesCompleted
        {
            get
            {
                return (subObjectives.Length == 0) || (compareType == CompareType.AND ? AllSubObjectivesAreCompleted() : OneOfSubObjectiveIsCompleted());
            }
        }
        #endregion

        #region Private Getters
        private bool AllSubObjectivesAreCompleted()
        {
            bool result = true;

            foreach(Objective objective in subObjectives)
            {
                result = result && objective.IsCompleted; 
            }

            return result;
        }

        private bool OneOfSubObjectiveIsCompleted()
        {
            bool result = false;


            foreach (Objective objective in subObjectives)
            {
                result = result || objective.IsCompleted;
            }

            return result;
        }
        #endregion
    }
}
