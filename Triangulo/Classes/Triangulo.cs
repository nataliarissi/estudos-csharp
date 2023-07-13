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