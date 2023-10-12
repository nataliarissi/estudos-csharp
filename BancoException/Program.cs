using Entities;

namespace Course{
    class Program{
        static void Main(string[] args){ 

        Metodos metodos = new Metodos();

        // metodos.Blocos();
        // metodos.TestarArquivo();
        // metodos.TestException();

        Console.WriteLine("Enter account data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        String holder = Console.ReadLine();
        Console.Write("Initial balance: ");
        double balance = double.Parse(Console.ReadLine());
        Console.Write("Withdraw limit: ");
        double withdrawLimit = double.Parse(Console.ReadLine());

        Account account = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        Console.Write("Enter amount for withdraw: ");
        double amount = double.Parse(Console.ReadLine());
        try
        {
            account.Withdraw(amount);
            Console.WriteLine("New balance: " + account.Balance);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Withdraw error: " + e.Message);
        }
        }
    }
}

//BLOCO TRY - código que pode acarretar a uma execeção
//BLOCO CATCH - código caso a executação ocorra
//BLOCO FINALLY - código a ser executado mesmo se acontecer erro ou não