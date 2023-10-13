using BancoInterface.Entities.CarRental;

class Program{
        static void Main(string[] args){
    //INTERFACE - estabelecer contrato que a classe\struct deve cumprir

        Console.WriteLine("Enter tental data ");
        Console.WriteLine("Car model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
        Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);        
    
        CarRental carRental = new CarRental(start, finish, new Vehicle(model));


    }   
}