using JointBench.Entities;
using JointBench.Entities.Calculation;

namespace JointBench{
    class Test{
        static void Main(string[] args){
            List<Product> list = new List<Product>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int m = 0; m < n; m++){
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1]);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:" + max);
        }
    }
}
