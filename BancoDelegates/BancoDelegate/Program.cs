using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using BancoDelegate.Entities;
using Entities;
using System.Linq;
using Microsoft.VisualBasic;

namespace BancoDelegate{
    class Program {
        static void Main (string[] args) {
            
            Console.Write("Enter full file path:");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader streamReader = File.OpenText(path)){
                while (!streamReader.EndOfStream){
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);
                    list.Add(new Product(name, price));
                }
            }
            
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price: " + avg);

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}

