namespace JointBench.Entities.Calculation{
    class CalculationService{
        public T Max<T>(List<T> list) where T : IComparable{
            if(list.Count == 0){
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for(int n = 1; n < list.Count; n++){
                if(list[n].CompareTo (max) >  0){
                    max = list[n];
                }
            }
            return max;
        }
    }
}