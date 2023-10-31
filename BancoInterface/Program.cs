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
}