namespace Banco.Natalia
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area(){
            return Largura * Altura;
            }

        public double Perimentro(){
            return 2 * (Largura + Altura);;
        }

        public double Diagonal(){
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}