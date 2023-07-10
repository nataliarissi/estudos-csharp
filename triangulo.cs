        static void PrintarNaTela(){
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //double - variavel de precisao decimal
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.AreaT();

            double areaY = y.AreaT();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
                Console.WriteLine("Maior area: X");
            else
                Console.WriteLine("Maior area: Y");
        }
    
classe:

using System; //pra usar math
namespace Banco.Natalia{
    class Triangulo{

        public double A; //num pode ser quebrado
        public double B;
        public double C;

        public double AreaT(){
            double p = (A + B + C ) / 2.0;
            return Math.Sqrt( p * (p - A) * (p - B) * (p - C));
        }


    }
}