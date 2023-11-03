using JointBench.Entities.Calculation;
using JointBench.Entities.Print;

namespace JointBench{
    class Methods{
        // public void Service(){

        //     PrintService printService = new PrintService();

        //     Console.Write("How many values? ");
        //     int n = int.Parse(Console.ReadLine());

        //     for(int m = 0; m<n; m++){
        //         int l = int.Parse(Console.ReadLine());
        //         printService.AddValue(l);
        //     }

        //     printService.Print();
        //     Console.WriteLine("First: " + printService.First());
        // }
        //reuso - está sem o Type safety

        public void ServiceString(){
            PrintServiceString printServiceString = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int m = 0; m<n; m++){
                string l = Console.ReadLine();
                printServiceString.AddValue(l);
            }

            printServiceString.Print();
            Console.WriteLine("First: " + printServiceString.First());
        }

        public void ServiceObject(){
            PrintServiceObject printServiceObject = new PrintServiceObject();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int m = 0; m<n; m++){
                int l = int.Parse(Console.ReadLine());
                printServiceObject.AddValue(l);
            }

            int a = (int)printServiceObject.First();
            int b = a + 2;
            Console.WriteLine(b);

            printServiceObject.Print();
            Console.WriteLine("First: " + printServiceObject.First());  
        }

        public void ServiceT(){
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int m = 0; m<n; m++){
                int l = int.Parse(Console.ReadLine());
                printService.AddValue(l);
            }

            // int a = printService.First();
            // int b = a + 2;
            // Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());            
        }

        public void CalculationTest(){
            List<int> list = new List<int>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int m = 0; m < n; m++){
                int l = int.Parse(Console.ReadLine());
                list.Add(l);
            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(list);

            Console.WriteLine("Max:" + max);
        }
    }   
}