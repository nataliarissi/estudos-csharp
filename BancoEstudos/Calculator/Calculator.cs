namespace BancoEstudos.Calculator
{
    public class Calculator
    {
//Método ruim para utilizar na calculadora
    // public static int Sum(int n1, int n2) {
    //  return n1 + n2;
    // }
    // public static int Sum(int n1, int n2, int n3) {
    //  return n1 + n2 + n3;
    // }
    // public static int Sum(int n1, int n2, int n3, int n4) {
    //  return n1 + n2 + n3 + n4;
    // }


//vetor que calcula números - Modificador de parâmetros
    // public static int Sum(params int[] numbers) {
    //   //avisa pro compilador que recebe uma quantidae variável de valores
    //   int sum = 0;
    //   for (int i=0; i<numbers.Length; i++) {
    //   //já pega tamanho do vetor automaticamente
    //     sum += numbers[i];
    //   }
    //   return sum;
    // }


    public static void Triple(ref int x) {
      //ref faz parâmetro ser referência para a variável original
      x = x * 3;
    }

    public static void Triple(int origin, out int result) {
      result = origin * 3;
    }

  }
}