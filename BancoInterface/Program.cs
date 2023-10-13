using BancoInterface.Entities.Rental;
using BancoInterface.Entities.Services;
namespace BancoInterface{
    class Program{
            static void Main(string[] args){
        //INTERFACE - estabelecer contrato que a classe\struct deve cumprir

            Console.WriteLine("Enter rental data ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);        

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());        

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);              
        }   
    }
}