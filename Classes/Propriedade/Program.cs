using System.Globalization; 
using Banco.Natalia;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {          
            Produto p = new Produto("TV", 500.0, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}