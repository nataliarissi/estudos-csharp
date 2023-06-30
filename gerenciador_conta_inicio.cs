//by Natalia Rissi
using BancoNatalia.Objetos;
var contas=new List<Conta>();
int opcao;
do
{
    Console.WriteLine("\tGerenciador de conta");
    Console.WriteLine("\nSelecione a opcao \n1.Cadastrar conta\n \n2.Remover Conta\n \n3.Mesclar Conta\n");
    opcao=int.Parse(Console.ReadLine() ?? "0");
    switch(opcao)
    {
        case 1:
        CadastrarConta();
        break;

        case 2:
        RemoverConta();
        break;

        case 3:
        MesclarConta();
        break;

    }
}while(opcao!= 0);

void CadastrarConta()
{
    Console.WriteLine("\tCadastro de Conta\n");
    Console.WriteLine("\nDigite sua agencia\n");  
    var agencia=Console.ReadLine();
    Console.WriteLine("\nDigite o numero da conta\n");
    var numeroConta=Console.ReadLine();

    var conta=new Conta();
    conta.NumeroAgencia=agencia;
    conta.NumeroConta=numeroConta;
    contas.Add(conta);
}

void RemoverConta()
{
    Console.WriteLine("\tAo continuar, todos os dados serao perdidos\n");
    Console.WriteLine("\nDigite a conta que deseje remover\n");
    var numeroConta=Console.ReadLine();
    contas.RemoveAll(conta => conta.NumeroConta==numeroConta);
}

void MesclarConta()
{

}