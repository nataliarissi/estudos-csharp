
using System.Collections.Generic;
using System.Reflection.Metadata;
using BancoEstudos.Aluno;
using BancoEstudos.Calculator;
using BancoEstudos.Estudante;
using BancoEstudos.Funcionario;

internal class ProgramAluno
{
    private static void Main(string[] args)
    {
    // Console.WriteLine("Notas no Ano ");
    // Console.WriteLine("Digite o nome do aluno: ");
    // string nome = Console.ReadLine();
    // Console.WriteLine("Digite a nota do aluno do primeiro trimestre: ");
    // double nota1 = double.Parse(Console.ReadLine());
    // Console.WriteLine("Digite a nota do aluno do segundo trimestre: ");
    // double nota2 = double.Parse(Console.ReadLine());
    // Console.WriteLine("Digite a nota do aluno do terceiro trimestre: ");
    // double nota3 = double.Parse(Console.ReadLine());

    // Aluno Nota = new Aluno(nome, nota1, nota2, nota3);

    // Console.WriteLine("Nota Final: " + Nota.NotaFinal());

///////////////////////////////////////////////////////////////////////////////////////////////
   
//     Estudante[] vect = new Estudante[10];
//     Console.Write("Quantos quartos serão alugados? ");

//     int n = int.Parse(Console.ReadLine());
//     for (int i = 1; i <= n; i++) {
//          Console.WriteLine();
//          Console.WriteLine($"Aluguel #{i}:");

//     Console.Write("Nome: ");
//     string nome = Console.ReadLine();

//     Console.Write("Email: ");
//     string email = Console.ReadLine();

//     Console.Write("Quarto: ");
//     int quarto = int.Parse(Console.ReadLine());

//     vect[quarto] = new Estudante(nome, email);
//     }

//     Console.WriteLine();
//     Console.WriteLine("Quartos ocupados:");

//     for (int i = 0; i < 10; i++) {
//          if (vect[i] != null) {
//     Console.WriteLine(i + ": " + vect[i]);
//     }
// }

///////////////////////////////////////////////////////////////////////////////////////////////
   
    // int s1 = Calculator.Sum(new int [] { 2, 3 });
    // int s2 = Calculator.Sum(2, 4, 3 ); 
    // //os dois de cima servem da mesma forma
    
    // Console.WriteLine(s1);
    // Console.WriteLine(s2);

///////////////////////////////////////////////////////////////////////////////////////////////
    
    // //REF
    // int a = 10;
    // Calculator.Triple(ref a);
    // //ref precisa ter valor incial - out não
    // Console.WriteLine(a);

    // //OUT
    // int a = 10;
    // int triple;
    // Calculator.Triple(a, out triple);
    // //faz referência para a segunda variável criada
    // Console.WriteLine(triple);
        
///////////////////////////////////////////////////////////////////////////////////////////////

    // string[] vect = new string[] {"Luke", "Itachi", "Madara"};
    
    // for (int n = 0; n <vect.Length; n++){
    //     Console.WriteLine(vect[n]);
    // }

    // Console.WriteLine("--------------");

    // foreach (string obj in vect){
    //     Console.WriteLine(obj);
    // }

///////////////////////////////////////////////////////////////////////////////////////////////

// //     List<string> list = new List<string>();
// // //cria uma lista vazia e instancia
// //     List<string> segundaLista = new List<string> {"Luke", "Itachi"};

//     List<string> list = new List<string>();

//     list.Add("Luke");
// //  list.Add(new Product(valor dos produtos));
//     list.Add("Itachi");
//     list.Add("Madara");
//     list.Add("Sakura");
// //Add - adiciona no final da lista
//     list.Insert(2, "Sasuke");
// //Insert - define posição
//     foreach (string obj in list){
//         Console.WriteLine(obj);
//         }
//     Console.WriteLine("Tamanho da Lista: " + list.Count);
    
//     string s1 = list.Find(x => x[0] == 'L');
// //seria : string s1 = list.Find(Test);
// // dentro do list.Find() - função que resume a bool abaixo
// //expressão lambda 
//     Console.WriteLine("First 'L': " + s1);

//     // static bool Test(string s){
//     //     return s[0] == 'L';
//     // }

//     string s2 = list.FindLast(x => x[0] == 'S');
//     Console.WriteLine("Last 'S': " + s2);

//     int primeiraPosicao = list.FindIndex(x => x[0] == 'S');
//     //posição número inteiro
//     Console.WriteLine("First position 'S': " + primeiraPosicao);
    
//     int segundaPosicao = list.FindLastIndex(x => x[0] == 'S');
//     Console.WriteLine("First position 'S': " + segundaPosicao);
       
// //filtar lista - criar uma nova para pegar os itens solicitados    

//     List<string> segundaLista = list.FindAll(x => x.Length == 6);
// //procurar itens com 6 caracteres
    
//     Console.WriteLine("--------------");
//     foreach (string obj in segundaLista){
//         Console.WriteLine(obj);
//     }

//     // list.Remove("Madara");
//     // list.RemoveAt(2); //remove a posição em que o elemento está
//     list.RemoveRange(2, 2);
//     //remover a partir da posição tal, tantos elementos  
//     Console.WriteLine("--------------");
//     foreach (string obj in list){
//         Console.WriteLine(obj);
//     }

//     list.RemoveAll(x => x[0] == 'I');
//     Console.WriteLine("--------------");
//     foreach (string obj in list){
//         Console.WriteLine(obj);
//     }

///////////////////////////////////////////////////////////////////////////////////////////////
    
    //  Console.Write("Deseja registrar quantos funcionários? ");
    //     int n = int.Parse(Console.ReadLine());

    //     List<Funcionario> list = new List<Funcionario>();

    //     for (int i = 1; i <= n; i++) {
    //         Console.WriteLine("Funcionario #" + i + ":");
    //         Console.Write("Id: ");
    //         int id = int.Parse(Console.ReadLine());
    //         Console.Write("Nome: ");
    //         string nome = Console.ReadLine();
    //         Console.Write("Salário: ");
    //         double salario = double.Parse(Console.ReadLine());
    //         list.Add(new Funcionario(id, nome, salario));
    //         Console.WriteLine();
    //     }

    //     Console.Write("Digite o Id do funcionário que terá aumento: ");
    //     int procurarId = int.Parse(Console.ReadLine());

    //     Funcionario funcionario = list.Find(x => x.Id == procurarId);
    //     if (funcionario != null) {
    //         Console.Write("Digite a porcentagem: ");
    //         double porcentagem = double.Parse(Console.ReadLine());
    //         funcionario.AumentoSalario(porcentagem);
    //     }
    //     else {
    //         Console.WriteLine("Id digitado não existe!");
    //     }

    //     Console.WriteLine();
    //     Console.WriteLine("Atualização dos funcionários:");
    //     foreach (Funcionario obj in list) {
    //         Console.WriteLine(obj);
    //     }

///////////////////////////////////////////////////////////////////////////////////////////////

    //MATRIZES BI
    // double [,] matriz = new double [2, 3];
    // //instancia uma matriz de duas linhas e 3 colunas
    // Console.WriteLine(matriz.Length);
    // //diz quantos elementos a matriz possui no total
    // Console.WriteLine(matriz.Rank);
    // //quantidade de linhas
    // Console.WriteLine(matriz.GetLength(0));
    // //dimensão 0 da matriz tem tamanho 2 (linhas)
    // Console.WriteLine(matriz.GetLength(1));
    // //dimensão 1 da matriz tem tamanho 3 (colunas)

///////////////////////////////////////////////////////////////////////////////////////////////

//     int n = int.Parse(Console.ReadLine());

//     int[,] matriz = new int[n, n];

//     for (int m = 0; m < n; n++){
// //percorrer as linhas
//         string[] values = Console.ReadLine().Split(' ');

//         for(int l = 0; l <n; l++){
// //percorrer as colunas
//             matriz[m, l] = int.Parse(values[l]);
// //percorrer e guardar os valores
//         }
//     }

//     Console.WriteLine("Diagonal Principal: ");
//     for (int i = 0; i < n; i++){
//         Console.WriteLine(matriz[i, i] + " ");
//     }
//     Console.WriteLine();

//     int contagem = 0;
// //percorrer uma matriz inteira
//     for(int m = 0; m < n; m++){
//         for(int l = 0; l < n; l++){
//             if(matriz[m, l] < 0){
//                 contagem++;
//             }
//         }
//     }
//     Console.WriteLine("Números negativos: " + contagem);

///////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Digite dois valores separados por espaço: ");
        var numerosDigitados = Console.ReadLine();
        string[] linha = numerosDigitados.Split(' ');
        int quantidadeLinhas = int.Parse(linha[0]);
        int quantidadeColunas = int.Parse(linha[1]);
        Console.WriteLine("Valores: " + quantidadeLinhas + ", " + quantidadeColunas);
        int[,] matriz = new int[quantidadeLinhas, quantidadeColunas];

        for (int linhaAtual = 0; linhaAtual < quantidadeLinhas; linhaAtual++) {
            Console.WriteLine("Digite a linha atual(inteira): " + (linhaAtual +1));
            string[] valores = Console.ReadLine().Split(' ');
            for (int colunaAtual = 0; colunaAtual < quantidadeColunas; colunaAtual++) {
                matriz[linhaAtual, colunaAtual] = int.Parse(valores[colunaAtual]);
            }
        }

        int numeroSelecionado = int.Parse(Console.ReadLine());

        for (int y = 0; y < quantidadeLinhas; y++) {
            for (int z = 0; z < quantidadeColunas; z++) {
                if (matriz[y, z] == numeroSelecionado) {
                    Console.WriteLine("Posição " + y + "," + z + ":");
                    if (z > 0) {
                        Console.WriteLine("Esquerda: " + matriz[y, z - 1]);
                    }
                    if (y > 0) {
                        Console.WriteLine("Em cima: " + matriz[y - 1, z]);
                    }
                    if (z < quantidadeColunas - 1) {
                        Console.WriteLine("Direita: " + matriz[y, z + 1]);
                    }
                    if (y < quantidadeLinhas - 1) {
                        Console.WriteLine("Embaixo: " + matriz[y + 1, z]);
                    }
                }
            }
        }
    }
}