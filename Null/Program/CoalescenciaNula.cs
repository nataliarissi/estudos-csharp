using Banco.Natalia;
namespace Course{
    class Program{
        static void Main(string[] args){    
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a); //deu 5
            Console.WriteLine(b); //deu 10

        }
    }
}