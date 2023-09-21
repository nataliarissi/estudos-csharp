
using BancoAprendizado.Conteudos.Entidades;
using BancoAprendizado.Conteudos.Entidades.Enums;

namespace Course{
    class Program{
        static void Main(string[] args){ 

// //CHAMAR MÉTODOS
//         IntervaloTempo timeSpan = new IntervaloTempo();
//         timeSpan.ComandosTimeSpan();
//         timeSpan.ComandosTimeSpanDerivados();

////////////////////////////////////////////////////////////////

        // Order order = new Order{
        //     Id = 1080,
        //     Moment = DateTime.Now,
        //     Status = OrderStatus.PendingPayment
        // };

        // Console.WriteLine(order);

        // string txt = OrderStatus.PendingPayment.ToString();

        // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        // Console.WriteLine(os);
        // Console.WriteLine(txt);

////////////////////////////////////////////////////////////////

        // Console.WriteLine("Enter department's name: ");
        // string deptName = Console.ReadLine();
        // Console.WriteLine("Enter worker data: ");
        // Console.WriteLine("Name: ");
        // string name = Console.ReadLine();
        // Console.Write("Level (Junior/Midlevel/Senior): ");
        // WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        // Console.WriteLine("Base salary: ");
        // double baseSalary = double.Parse(Console.ReadLine());

        // Department dept = new Department(deptName);
        // Worker worker = new Worker(name, level, baseSalary, dept);

        // Console.WriteLine("How many contracts to this worker? ");
        // int n = int.Parse(Console.ReadLine());

        // for(int m = 1; m <=n; m++){
        //     Console.WriteLine($"Enter #{m} contract data: ");
        //     Console.Write("Date (DD/MM/YYYY): ");
        //     DateTime date = DateTime.Parse(Console.ReadLine());
        //     Console.Write("Value per hour: ");
        //     double valuePerHour = double.Parse(Console.ReadLine());
        //     Console.WriteLine("Duration (hours): ");
        //     int hours = int.Parse(Console.ReadLine());

        //     HourContract contract = new HourContract(date, valuePerHour, hours);
        //     worker.AddContract(contract);
        // }   
        // Console.WriteLine();
        // Console.WriteLine("Enter month year to calculate income (MM/YYYY): ");
        // string monthAndYear = Console.ReadLine();
        // int month = int.Parse(monthAndYear.Substring(0, 2));
        // int year = int.Parse(monthAndYear.Substring(3));
        
        // Console.WriteLine("Name: " + worker.Name);
        // Console.WriteLine("Department: " + worker.Department.Name);        
        // Console.WriteLine("Name: " + worker.Name);
        // Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

////////////////////////////////////////////////////////////////

        Comment c1 = new Comment("Everyone lives their life within their own subjective interpretation");
        Comment c2 = new Comment("Wow that's awesome!");

        Post p1 = new Post(DateTime.Parse("17/06/2020 13:07:58"), "Itachi is the best character", "No matter how powerful you become, never try to do everything alone, otherwise you will fail!", 100);
        
        p1.AddComment(c1);
        p1.AddComment(c2);

        Comment c3 = new Comment("...View from cabin...");
        Comment c4 = new Comment("Wow that's awesome!");

        Post p2 = new Post(DateTime.Parse("21/07/2020 20:20:58"), "Kamisama - As soon as I heard you were in trouble, I came...", "I sincerely wish that the line of fate is not broken!", 500);
        
        p2.AddComment(c3);
        p2.AddComment(c4);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        
        }
    }
}
