using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDelegate.Entities{
    public class ExerciseProduct{
        public string Name { get; set; }
        public double Price { get; set; }

        public ExerciseProduct(string name, double price){
            Name = name;
            Price = price;
        }
    }
}