class Metodos{

    public void Blocos(){
        try{
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = firstNumber/secondNumber;
            Console.WriteLine(result);
        }
        catch(DivideByZeroException e){
            Console.WriteLine("Division by zero is not allowed! ");
        }
        catch(FormatException e){
            Console.WriteLine("Format error! " + e.Message);
        }
    }

    public void TestarArquivo(){
        FileStream fs = null;
        try {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e) {
            Console.WriteLine(e.Message);
        }
        finally {
            if (fs != null) {
                fs.Close();
            }
        }
    }
    public void TestException(){
    try{
        Console.Write("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());
        
        Reservation reservation = new Reservation(number, checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation: ");
        Console.Write("Check-in date (dd/MM/yyyy): ");
        checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy): ");
        checkOut = DateTime.Parse(Console.ReadLine());

        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation: " + reservation);
    }
    catch(DomainException e){
        Console.WriteLine("Error in reservation: " + e.Message);
    }
    catch(FormatException e){
        Console.WriteLine("Format error: " + e.Message);
    }
    catch(Exception e){
        Console.WriteLine("Unexpected error: " + e.Message);
    }
    }
}