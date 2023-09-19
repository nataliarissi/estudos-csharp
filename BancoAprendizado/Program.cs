
// var x = 10;
// var y = 20.0;
// var z = "Luke";

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// int n = int.Parse(Console.ReadLine());
// string dia;

///////////////////////////////////////////////////////

//     switch(n){
//         case 1: 
//             dia = "Segunda-Feira";
//             break;
//         case 2: 
//             dia = "Terça-Feira";
//             break;
//         case 3: 
//             dia = "Quarta-Feira";
//             break;
//         case 4: 
//             dia = "Quinta-Feira";
//             break;
//         case 5: 
//             dia = "Sexta-Feira";
//             break;
//         case 6: 
//             dia = "Sábado";
//             break;
//         case 7: 
//             dia = "Domingo";
//             break;
//         default:
//             dia = "Valor inválido";
//             break;
//     }
// Console.WriteLine("Dia: " + dia);

///////////////////////////////////////////////////////

// ternária
// (condição) ? valor_se_verdadeiro : valor_se_falso

double preco = double.Parse(Console.ReadLine());
double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
    // if(preco < 20.0)
    //     desconto = preco * 0.1;
    // else 
    //     desconto = preco * 0.05;

Console.WriteLine(desconto);
