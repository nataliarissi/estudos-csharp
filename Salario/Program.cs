using System.Globalization; 
using Banco.Natalia;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {          
            Funcionario1 func = new Funcionario1();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);
        
            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario em qual porcentagem?");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
