using Banco.Natalia;
using System.Globalization;
namespace Course{
    class Program{
        static void Main(string[] args){    
            
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int m = 0; m < n; m++){
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[m] = new Product {Name = name, Price = price};
                //podia ser feito com construtores
            }

            double soma = 0.0;
            for(int m = 0; m < n; m++){
                soma+= vect[m].Price;
            }

            double media = soma / n;
            Console.WriteLine("Media dos preços = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
//estilo referencia