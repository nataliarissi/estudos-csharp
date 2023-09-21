using System.Data.SqlTypes;
using System.Globalization;

public class StringVar{
public void Var(){
    var x = 10;
    var y = 20.0;
    var z = "Luke";

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
}

public void SwitchCondicao(){
    int n = int.Parse(Console.ReadLine());
    string dia;

    switch(n){
        case 1: 
            dia = "Segunda-Feira";
            break;
        case 2: 
            dia = "Terça-Feira";
            break;
        case 3: 
            dia = "Quarta-Feira";
            break;
        case 4: 
            dia = "Quinta-Feira";
            break;
        case 5: 
            dia = "Sexta-Feira";
            break;
        case 6: 
            dia = "Sábado";
            break;
        case 7: 
            dia = "Domingo";
            break;
        default:
            dia = "Valor inválido";
            break;
        }
    Console.WriteLine("Dia: " + dia);
}

public void Ternaria(){
    // (condição) ? valor_se_verdadeiro : valor_se_falso

    double preco = double.Parse(Console.ReadLine());
    double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        // if(preco < 20.0)
        //     desconto = preco * 0.1;
        // else 
        //     desconto = preco * 0.05;

    Console.WriteLine(desconto);
}

public void StringModificacao(){
    string original = "abcde FGHIJ ABC abc DEFG     ";
    //string é uma varável imutável, não altera contéudo
    string s1 = original.ToUpper();
    string s2 = original.ToLower();
    string s3 = original.Trim();

    int n1 = original.IndexOf("bc"); //procura
    int n2 = original.LastIndexOf("bc");

    string s4 = original.Substring(3);
    string s5 = original.Substring(3, 5);

    string s6 = original.Replace('a', 'x');
    string s7 = original.Replace("abc", "xy");

    bool b1 = String.IsNullOrEmpty(original);
    bool b2 = String.IsNullOrWhiteSpace(original);

    Console.WriteLine("Original: " + original);
    Console.WriteLine("ToUpper: " + s1);
    Console.WriteLine("ToLower: " + s2);
    Console.WriteLine("Trim: " + s3); //apaga espaço em branco
    Console.WriteLine("IndexOf('bc'): " + n1); //aparece na primeira posição
    Console.WriteLine("LastIndexOf('bc'): " + n2); //última ocorrência do bc
    Console.WriteLine("Substring(3): " + s4); //recortar string
    Console.WriteLine("Substring(3, 5): " + s5); //imprimiu 5 caracteres a partir da posição 3
    Console.WriteLine("Replace('a', 'x'): " + s6); //substituir parte da string por outra
    Console.WriteLine("Replace('abc', 'xy'): " + s7);
    Console.WriteLine("IsNullOrEmpty: " + b1);
    Console.WriteLine("IsNullOrWhiteSpace: " + b2); //para conferir se são espaços em branco
}
}