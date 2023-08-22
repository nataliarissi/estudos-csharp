
namespace BancoEstudos.Aluno
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3){
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public string NotaFinal(){
            double Resultado;

            if(Nota1 <= 30 && Nota2 <= 35 && Nota3 <= 35){
                Resultado = Nota1 + Nota2 + Nota3;
                if(Resultado >= 60)
                    return "Aprovado: " + Resultado;
                else
                {
                    Console.WriteLine("Reprovado: " + Resultado);
                    return "Pontos Faltantes: " + (60 - Resultado);
                }
            }
            else
                return "Inválido";
        }
    }
}