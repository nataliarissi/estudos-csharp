using BancoDelegate.Entities;

public class Methods{

    public void ShowCalculationServiceOne(){
        // namespace BancoDelegate
        delegate double BinaryNumericOperation(double n1, double n2);
    // class Program 
        // static void Main (string[] args)

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            // BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            
            double result = op.Invoke(a, b);
            // double result = op(a, b);
            // double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            //Invoke executa todos métodos na ordem implementados
        }

        public void ShowCalculationServiceTwo(){
        // namespace BancoDelegate

        delegate void BinaryNumericOperation(double n1, double n2);
        // class Program
            // static void Main (string[] args)

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServiceTwo.ShowSum;
            op += CalculationServiceTwo.ShowMax;

            op(a, b);
            // op.Invoke(a, b);
        }

        public void TestPredicateOne{
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
            list.Add(new Product("Keyboard", 90));
        
            list.RemoveAll(p => p.Price >= 100);
            //argument predicate
            foreach(Product p in list){
                Console.WriteLine(p);
            }
        }

        public void TestPredicateTwo{
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
            list.Add(new Product("Keyboard", 90));
        
            list.RemoveAll(ProductTest);
            foreach(Product p in list){
                Console.WriteLine(p);
            }
        // }
        //método auxilar que recebe produto e devolve boolean
            public static bool ProductTest(Product p){
                return p.Price >= 100;
            }
        }

        public void TestAction(){
                
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
            list.Add(new Product("Keyboard", 90));

            // Action<Product> action = UpdatePrice;
            // Action<Product> action = p => {p.Price += p.Price * 0.1;};

            list.ForEach(UpdatePrice);
            // list.ForEach(action);
            foreach (Product p in list){
                Console.WriteLine(p);
            }
        // }
            static void UpdatePrice(Product p){
                p.Price += p.Price * 0.1;
        }
        //OU
            // List<Product> list = new List<Product>();

            // list.Add(new Product("Computer", 1800));
            // list.Add(new Product("HD", 80));
            // list.Add(new Product("Mouse", 370));
            // list.Add(new Product("Keyboard", 90));

            // list.ForEach(p => {p.Price += p.Price * 0.1;});
            // foreach (Product p in list){
            //     Console.WriteLine(p);
        }

    //using System.Linq;
        public void TestFunc(){

            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
            //retorna um valor, recebe zero ou mais argms
            //select pega uma coleção e transforma em outra
        
            List<string> result = list.Select(NameUpper).ToList();
            //cada elemento dessa implemntação vai ser um elemento da função
            foreach(string s in result){
                Console.WriteLine(s);
            }
        }
        // // dps da main
        // //static string NameUpper (Product p){
        //     return p.name.ToUpper();
        // }

        public void TestFuncDelegate(){
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
        
            Func<Product,string> func = NameUpper;
            //recebe produto, retorna string

            List<string> result = list.Select(func).ToList();
            foreach(string s in result){
                Console.WriteLine(s);
            }
        }
        // // dps da main
        // //static string NameUpper (Product p){
        //     return p.name.ToUpper();
        // }


        //com funcoes lambda
        public void TestFuncLambda(){
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));
        
            Func<Product,string> func = p => p.Name.ToUpper();
            //se colocar {} ele vai esperar um retorn 

            List<string> result = list.Select(func).ToList();
            foreach(string s in result){
                Console.WriteLine(s);
            }
        }

        public void TestFuncDireto(){
            List<Product> list = new List<Product>();

            list.Add(new Product("Computer", 1800));
            list.Add(new Product("HD", 80));
            list.Add(new Product("Mouse", 370));

            List<string> result = list.Select(p => p.Name.ToUpper).ToList();
            foreach(string s in result){
                Console.WriteLine(s);
            }

        public void TestLINQ(){
            //criar/espeficar data source - onde vem dados (bancos de dados, arquivo, array)
            //definir query(consulta) - expressão com LINQ
            //executar query - foreach ou outro forçar a consulta a ser executada

            int[] numbers = new int []{ 2, 3, 4, 5 };
            
            IEnumerable<int>result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach(int x in result){
                Console.WriteLine(x);
            }
        }
    }
}