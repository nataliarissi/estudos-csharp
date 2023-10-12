class Program{
        static void Main(string[] args){ 
        Metodos metodos = new Metodos();
        // metodos.FilesTest();
        // metodos.StreamTest();
        // metodos.UsingBlock();
        // metodos.StreamWriterTest();
        // metodos.PathTest();

        Console.Write("Enter file full path: ");
        string sourceFilePath = Console.ReadLine();

        try {
            string[] lines = File.ReadAllLines(sourceFilePath);

            string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\summary.csv";

            Directory.CreateDirectory(targetFolderPath);

            using (StreamWriter streamWriter = File.AppendText(targetFilePath)) {
                foreach (string line in lines) {

                    string[] fields = line.Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);
                    int quantity = int.Parse(fields[2]);

                    Product prod = new Product(name, price, quantity);

                    streamWriter.WriteLine(prod.Name + "," + prod.Total());
                }
            }
        }
        catch (IOException e) {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}