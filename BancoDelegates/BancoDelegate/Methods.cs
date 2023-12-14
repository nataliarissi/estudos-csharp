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

        public void TesteLINQTWO(){
        // static void Print<T>(string message, IEnumerable<T> collection){
            Console.WriteLine(message);
            foreach(T obj in collection){
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        // }
        // static void Main (string[] args) {
            Category firstCategory = new Category(){ Id = 1, Name = "Tools", Tier = 2 };
            Category secondCategory = new Category(){ Id = 2, Name = "Computers", Tier = 1 };
            Category thirdCategory = new Category(){ Id = 3, Name = "Electronics", Tier = 1 };
        
            List<Products> products = new List<Products>(){
                new Products { Id = 1, Name = "Computer", Price = 1110, Category = secondCategory },
                new Products { Id = 2, Name = "Hammer", Price = 90, Category = firstCategory },
                new Products { Id = 3, Name = "TV", Price = 1700, Category = thirdCategory },
                new Products { Id = 4, Name = "Notebook", Price = 1300, Category = secondCategory },
                new Products { Id = 5, Name = "Saw", Price = 80, Category = firstCategory },
                new Products { Id = 6, Name = "Tablet", Price = 700, Category = secondCategory },
                new Products { Id = 7, Name = "Camera", Price = 700, Category = thirdCategory },
                new Products { Id = 8, Name = "Printer", Price = 350, Category = thirdCategory },
                new Products { Id = 9, Name = "MacBook", Price = 1800, Category = secondCategory },
                new Products { Id = 10, Name = "Sound Bar", Price = 700, Category = thirdCategory },
                new Products { Id = 11, Name = "Levej", Price = 70, Category = firstCategory }
            };

            var firstResult = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            //filtrar
            Print("TIER 1 AND PRICE < 900 ", firstResult);

            var secondResult = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS ", secondResult);

            var thirdResult = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT ", thirdResult);

            var fourthResult = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME ", thirdResult);
        
            var fifthResult = fourthResult.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4 ", fifthResult);
        
            
            var sixthResult = products.FirstOrDefault();
            Console.WriteLine("FIRST OF DEFAULT TEST 1: " + sixthResult);

            var seventhResult = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine("FIRST OF DEFAULT TEST 2: " + seventhResult);
        
            
            var eighthResult = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT TEST 1: " + eighthResult);
        
            var ninthResult = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SINGLE OR DEFAULT TEST 2: " + ninthResult);
        
            
            var tenthResult = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + tenthResult);

            var eleventhResult = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + eleventhResult);

            var twelveResult = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + twelveResult);

            var thirteenResult = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + thirteenResult); 

            var fourteenResult = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine("Category 5 Average prices: " + fourteenResult);

            var fifteenResult = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + fifteenResult);
        
            
            var sixteenResult = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in sixteenResult){
                Console.WriteLine("Category " + group.Key.Name);
                foreach (Product p in group){
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }

        public void TestarLINQSQL(){
    // static void Print<T>(string message, IEnumerable<T> collection){
        // Console.WriteLine(message);
        // foreach(T obj in collection){
        //     Console.WriteLine(obj);
        // }
        // Console.WriteLine();
        // }
        // static void Main (string[] args) {
            Category firstCategory = new Category(){ Id = 1, Name = "Tools", Tier = 2 };
            Category secondCategory = new Category(){ Id = 2, Name = "Computers", Tier = 1 };
            Category thirdCategory = new Category(){ Id = 3, Name = "Electronics", Tier = 1 };
        
            List<Products> products = new List<Products>(){
                new Products { Id = 1, Name = "Computer", Price = 1110, Category = secondCategory },
                new Products { Id = 2, Name = "Hammer", Price = 90, Category = firstCategory },
                new Products { Id = 3, Name = "TV", Price = 1700, Category = thirdCategory },
                new Products { Id = 4, Name = "Notebook", Price = 1300, Category = secondCategory },
                new Products { Id = 5, Name = "Saw", Price = 80, Category = firstCategory },
                new Products { Id = 6, Name = "Tablet", Price = 700, Category = secondCategory },
                new Products { Id = 7, Name = "Camera", Price = 700, Category = thirdCategory },
                new Products { Id = 8, Name = "Printer", Price = 350, Category = thirdCategory },
                new Products { Id = 9, Name = "MacBook", Price = 1800, Category = secondCategory },
                new Products { Id = 10, Name = "Sound Bar", Price = 700, Category = thirdCategory },
                new Products { Id = 11, Name = "Levej", Price = 70, Category = firstCategory }
            };

            var firstResult = 
                        from p in products
                        where p.Category.Tier == 1 && p.Price < 900
                        select p;

            var secondResult = 
                        from p in products
                        where p.Category.Name == "Tools"
                        select p.Name;

            var thirdResult = 
                        from p in products
                        where p.Name[0] == 'C'
                        select new {
                            p.Name,
                            p.Price,
                            CategoryName = p.Category.Name
                        };

            var fourthResult = 
                        from p in products
                        where p.Category.Tier == 1
                        orderby p.Name 
                        orderby p.Price
                        select p;

            var fifthResult =
                        (from p in fourthResult
                        select p).Skip(2).Take(4);

            var sixthResult =
                        (from p in products 
                        select p).FirstOrDefault(); 
            
            var seventhResult = 
                        (from p in products
                        where p.Price > 3000
                        select p).FirstOrDefault();

            var sixteenResult = 
                        from p in products
                        group p by p.Category;                            
    //     }
    // }
        }
    }