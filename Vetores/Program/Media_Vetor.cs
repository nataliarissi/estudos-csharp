using Banco.Natalia;
using System.Globalization;
namespace Course{
    class Program{
        static void Main(string[] args){    
            
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            //vetor
        
            for(int m = 0; m < n; m++){
                vect[m] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int m = 0; m < n; m++){
                soma += vect[n];
            }
            
            double media = soma/n;

            Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
//VETORES
//array - arranjo 
//dados do msm tipo - uma coluna que comeca do zero - posicoes
//ou seja, todas double, string
//aonde cada espaco tem um dado diferente
//vantagem - acessar imediatamente a posicao desejada
//desvantagem - tamanho fixo e dificuldade para realizar insercoes e delecoes
