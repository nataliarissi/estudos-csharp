class Metodos{

    public void FilesTest(){
        string sourcePath = @"c:\temp\file1.txt";
        string targetPath = @"c:\temp\file2.txt";

        try{
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath); //copiar arquivo

            string[] lines = File.ReadAllLines(sourcePath); //ler arquivo
            foreach(string line in lines){
                Console.WriteLine(line);
            }
        }
        catch(IOException e){
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    //FILE - static members
    //FILEINFO - instance members
    }

    public void StreamTest(){
        string path = @"c:\temp\file1.txt";
        // FileStream fileStream = null;
        StreamReader streamReader = null;

        try{
            // fileStream = new FileStream(path, FileMode.Open);
            // streamReader = new StreamReader(fileStream);
            streamReader = File.OpenText(path); //instancia ambas stream
            while(!streamReader.EndOfStream){
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch(IOException e){
            Console.WriteLine("An error accurred");
            Console.WriteLine(e.Message);
        }
        finally{
            if(streamReader != null) streamReader.Close();
            // if(fileStream != null) fileStream.Close();
        }
    }
    //FILESTREAM - ler e escrever
    //STREAMREADER - ler caracteres a partir da stream - transmitir dados em sequência

    public void UsingBlock(){
        string path = @"c:\temp\file1.txt";

        try{
            // using(FileStream fileStream = new FileStream(path, FileMode.Open)){ //instanciar recursos
            //     using(StreamReader streamReader = new StreamReader(fileStream)){
                using (StreamReader streamReader = File.OpenText(path)){
                    while(!streamReader.EndOfStream){
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        catch(IOException e){
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
    //USING BLOCK - garante que objetos IDisposable sejam fechados

    public void StreamWriterTest(){
        string sourcePath = @"c:\temp\file1.txt";
        string targetPath = @"c:\temp\file2.txt";

    //salvar o conteúdo de file1 e passar tudo em maiúsculo para o file2
        try{
            string[] lines = File.ReadAllLines(sourcePath);

            using(StreamWriter streamWriter = File.AppendText(targetPath)){
                foreach(string line in lines){
                    streamWriter.WriteLine(line.ToUpper());
                }
            }
        }
        catch(IOException e){
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
    //STREAMWRITER - escreve caracteres a partir de uma stream

    public void DirectoryTest(){
        
        string path = @"c:\temp\myfolder";

        try{
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            // IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            foreach(string s in folders){
                Console.WriteLine(s);
            }

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach(string s in files){
                Console.WriteLine(s);
            }

            Directory.CreateDirectory(path + "\\newFolder"); //ou @"\newFolder"
            // Directory.CreateDirectory(@"c:\temp\myfolder\newFolder");
        }
        catch(IOException e){
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }       
    }
    //DIRECTORY - operação com pastas

    public void PathTest(){
        string path = @"c:\temp\myFolder\file1.txt";

        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetExtension: " + Path.GetExtension(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
        Console.WriteLine("GetTempPath: " + Path.GetTempPath());
    }
    //PATH - realiza operações com strings que contém info de arquivos ou pastas
}