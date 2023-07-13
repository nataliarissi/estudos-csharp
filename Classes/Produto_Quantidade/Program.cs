using System.Globalization; 
using Banco.Natalia;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {          
            Produto p = new Produto(); //variavel p

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();//p.Nome vai receber o dado para ler a string
            Console.WriteLine("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); 

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos ao estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); 

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
