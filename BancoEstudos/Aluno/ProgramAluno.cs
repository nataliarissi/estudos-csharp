
using BancoEstudos.Aluno;

internal class ProgramAluno
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Notas no Ano ");
        Console.WriteLine("Digite o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a nota do aluno do primeiro trimestre: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do aluno do segundo trimestre: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a nota do aluno do terceiro trimestre: ");
        double nota3 = double.Parse(Console.ReadLine());

        Aluno Nota = new Aluno(nome, nota1, nota2, nota3);

        Console.WriteLine("Nota Final: " + Nota.NotaFinal());
    }
}