namespace JointBench.Entities{
    public class Product : IComparable{

        public Product(string name, double price){
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString(){
            return Name
                + ","
                + Price;
        }

        public int CompareTo(object? obj){
            if(!(obj is Product)){
                throw new ArgumentException("Comparing erro: argument is not a Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}