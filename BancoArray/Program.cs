
using System.ComponentModel;

namespace Course{
    class Program{
        static void Main(string[] args){

            List<int> listaNumerosInteiros = new List<int>();

            //add separadamente
            listaNumerosInteiros.Add(100);
            listaNumerosInteiros.Add(50);
            listaNumerosInteiros.Add(11);

            //add tudo junto
            int[] numerosInteiros = new int[] {77, 9, 21, 88};
            listaNumerosInteiros.AddRange(numerosInteiros);

            //contar os elementos da lista
            int[] contarNumerosInteiros = new int[] { 16, 18, 23, 12 };
            listaNumerosInteiros.AddRange(contarNumerosInteiros);
            Console.WriteLine("A lista tem " + listaNumerosInteiros.Count() + " itens.");

            //acessar primeiro número
            Console.WriteLine("Primeiro item da lista: " + listaNumerosInteiros[0]);

            //procurar TODO array
            foreach(int numeroInteiro in listaNumerosInteiros){
                Console.WriteLine(numeroInteiro);
            }

            //pegar o item que eu quero
            for (int n = 0; n < listaNumerosInteiros.Count; n++) {
                int numeros = listaNumerosInteiros[n];
                Console.WriteLine("FOR: " + numeros);
            }
        
            Console.WriteLine();
            Console.WriteLine("1: SOMA" );
            List<int> listaNumeros = new List<int> { 10, 88, 7, 11, 2 };

            int somaTotal = 0;

            foreach (int numeroInteiro in listaNumeros){
                somaTotal += numeroInteiro;
            }

            Console.WriteLine("Soma total: " + somaTotal);
        
            Console.WriteLine();
            Console.WriteLine("2: MÉDIA" );

            List<int> listaNumeroSolicitado = new List<int>();

            Console.WriteLine("Digite quantos números deseja digitar: ");
            int quantidadeNumero = int.Parse(Console.ReadLine());

            for(int n = 0; n < quantidadeNumero; n++){
                Console.WriteLine($"Digite o {n + 1}° número: ");
                int numero = int.Parse(Console.ReadLine());
                listaNumeroSolicitado.Add(numero);
            }
            double mediaNumeros = listaNumeroSolicitado.Average();
            Console.WriteLine(mediaNumeros);

            Console.WriteLine();
            Console.WriteLine("3: MAIOR/MENOR" );

            List<int> listaNumeroInteiro= new List<int>() { 90, 7, 1, 110, 668, 20, 10000, 881};
            int maiorNumero = listaNumeroInteiro.Max();
            int menorNumero = listaNumeroInteiro.Min();
            Console.WriteLine("Maior: " + maiorNumero);
            Console.WriteLine("Menor: " + menorNumero);


            Console.WriteLine();
            Console.WriteLine("4:" );

        }
    }
}
