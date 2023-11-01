using BancoInterface.Entities;
using BancoInterface.Entities.Devices;
using BancoInterface.Entities.Rental;
using BancoInterface.Entities.Services.BrazilTaxService;
using BancoInterface.Entities.Shapes;

namespace BancoInterface{
    class Program{
            static void Main(string[] args){

                string path = @"c:\temp\in.txt";

                try{
                    using (StreamReader streamReader = File.OpenText(path)){
                        List<Employee> list = new List<Employee>();
                        while(!streamReader.EndOfStream){
                            list.Add(new Employee(streamReader.ReadLine()));
                        }
                        list.Sort();
                        foreach(Employee emp in list){
                            Console.WriteLine(emp);
                        }
                    }
                }catch(IOException e){
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
        }   
    }
}