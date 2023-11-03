namespace JointBench.Entities.Print{
    class PrintService<T>{

        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value){
            if(_count == 10){
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T First(){
            if(_count == 0){
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print(){
            Console.Write("[");
            for(int n = 0; n<_count - 1; n++){
                Console.Write(_values[n] + ", ");
            }
            if(_count > 0){
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}