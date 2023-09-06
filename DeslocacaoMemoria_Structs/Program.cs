using Banco.Natalia;
namespace Course{
    class Program{
        static void Main(string[] args){    

            Point p; //ja cria o new-valor
            p.X=10;
            p.Y=20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

        }
    }
}