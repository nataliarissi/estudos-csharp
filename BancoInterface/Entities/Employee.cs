namespace BancoInterface.Entities{
    public class Employee : IComparable{
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee){
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }

        public override string ToString(){
            return Name + ", " + Salary;
        }

        public int CompareTo(object? obj){
            if(!(obj is Employee)){
                throw new ArgumentException("Comparing error: argument is not a Employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}