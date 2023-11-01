using BancoInterface.Entities;
using BancoInterface.Entities.Devices;
using BancoInterface.Entities.Rental;
using BancoInterface.Entities.Services.BrazilTaxService;
using BancoInterface.Entities.Shapes;
using BancoInterface.Enum;

public class Methods{

    public void RentalTest(){
        //INTERFACE - estabelecer contrato que a classe\struct deve cumprir

        Console.WriteLine("Enter rental data ");
        Console.Write("Car model: ");
        string model = Console.ReadLine();
        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);        

        Console.Write("Enter price per hour: ");
        double pricePerHour = double.Parse(Console.ReadLine());
        Console.Write("Enter price per day: ");
        double pricePerDay = double.Parse(Console.ReadLine());        

        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("INVOICE: ");
        Console.WriteLine(carRental.Invoice);   
    }

    public void ShapeTest(){
        IShape firstShape = new Circle() { Radius = 2, Color = Color.White};  //Enum
        IShape secondShape = new Rectangle () { Width = 3.5, Height = 4.2, Color = Color.Black};
    
        Console.WriteLine(firstShape);
        Console.WriteLine(secondShape);
    }

    public void DenviceTest(){
        Printer printer = new Printer() {SerialNumber = 1080};
        printer.ProcessDoc("My letter");
        printer.Print("My letter");

        Scanner scanner = new Scanner() {SerialNumber = 2007};
        scanner.ProcessDoc("My Email");
        Console.WriteLine(scanner.Scan());
    
        ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3007};
        comboDevice.ProcessDoc("My dissertation");
        comboDevice.Print("My dissertation");
        Console.WriteLine(comboDevice.Scan());
    }

    public void buscarLerLista(){
        string path = @"c:\temp\in.txt";

        try{
            using (StreamReader streamReader = File.OpenText(path)){
                List<string> list = new List<string>();
                while(!streamReader.EndOfStream){
                    list.Add(streamReader.ReadLine());
                }
                //ordenar lista
                list.Sort();
                foreach(string str in list){
                    Console.WriteLine(str);
                }
            }
        }catch(IOException e){
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}