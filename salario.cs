        static void SalarioPorcentagem(){
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

classe:

using System.Globalization;

namespace Banco.Natalia
{
    public class Funcionario1
    {
        
            public string Nome;
            public double SalarioBruto;
            public double Imposto;

            public double SalarioLiquido(){
                return SalarioBruto - Imposto;
            }
            public void AumentarSalario(double porcentagem){
                SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
            }
        public override string ToString(){
            return Nome
            + ", R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}