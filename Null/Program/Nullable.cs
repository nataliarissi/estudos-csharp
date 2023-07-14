using Banco.Natalia;
namespace Course{
    class Program{
        static void Main(string[] args){    

            double ? x = null; 
            //Nullable<double> - ? opcional
            double ? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            //pegar o valor que tem, se nao, valor nulo

            Console.WriteLine(x.HasValue); //false
            //dizer se existe valor dentro do x ou nao
            Console.WriteLine(y.HasValue); //true
            
            if (x.HasValue)
                Console.WriteLine(x.Value); //da erro pq e nulo
            //pegar valor diretamente do x
            else
                Console.WriteLine("X is null");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
        }
    }
}

//nullable usado para dados opcionais - structs