using BancoAprendizado.Conteudos.Entidades.Account;

namespace Course{
    class Program{
        static void Main(string[] args){
    //não pode ser instanciado - herança total

        List<Account> list = new List<Account>();

        list.Add(new SavingAccount(1001, "Luke", 500, 0.1));
        list.Add( new BusinessAccount(1002, "Itachi", 500, 400));
        list.Add(new SavingAccount(1003, "Sasuke", 500, 0.01));
        list.Add(new BusinessAccount(1004, "Sakura", 500, 500));

        double sum = 0;
    //atribuir o mesmo valor de saldo para todas as contas
        foreach(Account acc in list){
            sum += acc.Balance;
        }

        Console.WriteLine("Total balance:" + sum);

        foreach(Account acc in list){
            acc.Withdraw(10);
        }
    //imprimir na tela e monstrar saldo atualizado de cada conta
        foreach(Account acc in list){
            Console.WriteLine("Updated balance for account " 
                + acc.Number + ":" + acc.Balance);
        }
    Console.WriteLine();
/////////////////////////////////////////////////////////////////////////////

    //métodos não tem implementação

    List<Shape> listS = new List<Shape>();

    Console.WriteLine("Enter the number of shapes: ");
    int n = int.Parse(Console.ReadLine());

    for(int m = 1; m <=n; m++){
        Console.WriteLine($"Shape #{m} data: ");
        Console.Write("Rectangle or Circle (r/c)? ");
        char ch = char.Parse(Console.ReadLine());
        Console.Write("Color (Black/Blue/White): ");
        Color color = Enum.Parse<Color>(Console.ReadLine());

        if(ch == 'r'){
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());            
            listS.Add(new Rectangle(width, height, color));
        }else{
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            listS.Add(new Circle(radius, color));
        }
    }
        Console.WriteLine();
        Console.WriteLine("SHAPE AREAS: ");
        foreach(Shape shape in listS){
            Console.WriteLine(shape.Area());
        }

        }
    }
}