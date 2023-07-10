        static void Retangulo(){
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retangulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimentro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

classe:

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