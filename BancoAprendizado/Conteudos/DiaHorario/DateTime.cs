//datetime representa data e hora

using System.Globalization;

public class DataHora{
public void DataTime(){

//armazenamento de data e horário
// DateTime d1 = DateTime.Now;

// Console.WriteLine(d1);
// Console.WriteLine(d1.Ticks);

    DateTime d1 = new DateTime(2023, 09, 19);
    Console.WriteLine(d1);

    //especificar horário
    DateTime d2 = new DateTime(2018, 09, 19, 23, 40, 7);
    Console.WriteLine(d2);

    DateTime d3 = new DateTime(2018, 09, 19, 23, 40, 7, 500);
    Console.WriteLine(d3);

    //horário global ou local - DateTimeKind

    DateTime d4 = DateTime.Now;
    Console.WriteLine(d4);

    DateTime d5 = DateTime.Today; //dia de hoje e horário zerado
    Console.WriteLine(d5);

    DateTime d6 = DateTime.UtcNow; //horário universal
    Console.WriteLine(d6);
}

public void FormatacaoDateTime(){
//com formatação e horário específicos
    DateTime d1 = DateTime.Parse("2000-08-21");
    DateTime d2 = DateTime.Parse("2000-08-21 13:07:58");
    DateTime d3 = DateTime.Parse("21/08/2000"); //brasileiro
    DateTime d4 = DateTime.Parse("21/08/2000 13:07:58");

    Console.WriteLine(d1);
    Console.WriteLine(d2);
    Console.WriteLine(d3);
    Console.WriteLine(d4);

    DateTime d5 = DateTime.ParseExact("2000-08-21", "yyyy-MM-dd", CultureInfo.InvariantCulture);
    Console.WriteLine(d5);

    DateTime d6 = DateTime.ParseExact("21/08/2000 13:07:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
    Console.WriteLine(d6);
}

public void DateTimePropriedades(){
        DateTime d = new DateTime(2001, 8, 17, 21, 47, 58, 275);

        Console.WriteLine(d);
        Console.WriteLine("1) Date: " + d.Date);
        Console.WriteLine("2) Day: " + d.Day);
        Console.WriteLine("3) DayOfWee: " + d.DayOfWeek);
        Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
        Console.WriteLine("5) Hour: " + d.Hour);
        Console.WriteLine("6) Kind: " + d.Kind); //local ou universal
        Console.WriteLine("7) Millisecond: " + d.Millisecond);
        Console.WriteLine("8) Minute: " + d.Minute);
        Console.WriteLine("9) Month: " + d.Month);
        Console.WriteLine("10) Second: " + d.Second);
        Console.WriteLine("11) Ticks: " + d.Ticks);
        Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
        Console.WriteLine("13) Year: " + d.Year);
}

public void ComandosFormatacaoDT(){
    DateTime d = new DateTime(2001, 8, 17, 21, 47, 58);

        string s1 = d.ToLongDateString();
        string s2 = d.ToLongTimeString();
        string s3 = d.ToShortDateString(); //data resumida
        string s4 = d.ToShortTimeString(); //só imprime data e segundo

        string s5 = d.ToString();

    //máscara de formatação
        string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); //manualmente
        string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");


        Console.WriteLine(d.ToLongDateString()); //convertendo para string
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);        
        Console.WriteLine(s7);
}

public void OperacoesDateTime(){
    DateTime d = new DateTime(2001, 8, 17, 21, 47, 58);

    DateTime d2 = d.AddHours(2);
//acrescentar valores ao horário

    DateTime d3 = d.AddMinutes(7);

//diferença entre datas
    DateTime d4 = new DateTime(2001, 10, 11);
    DateTime d5 = new DateTime(2001, 10, 18);
    
    TimeSpan t = d5.Subtract(d4); //duração
                //data final - data incial

    Console.WriteLine(d);
    Console.WriteLine(d2);
    Console.WriteLine(d3);
    Console.WriteLine(t);

// //calcular vencimento de boletos
//     DateTime d = DateTime.Now; //gerar boleto
// //vencimento do boleto
//     DateTime d1 = d.AddDays(7);
}

public void EnumDateTimeKind(){
//instanciando
    DateTime d1 = new DateTime(2000, 8, 11, 7, 4, 21, DateTimeKind.Local);

    DateTime d2 = new DateTime(2000, 8, 11, 7, 4, 21, DateTimeKind.Utc);

    DateTime d3 = new DateTime(2000, 8, 11, 7, 4, 21);

    // Console.WriteLine(d1);
    // Console.WriteLine(d2);
    // Console.WriteLine(d3);

    Console.WriteLine("d1: " + d1);
    Console.WriteLine("d1 Kind: " + d1.Kind);
    Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
    Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
    Console.WriteLine();
    Console.WriteLine("d2: " + d2);
    Console.WriteLine("d2 Kind: " + d2.Kind);
    Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
    Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
    Console.WriteLine();
    Console.WriteLine("d3: " + d3);
    Console.WriteLine("d3 Kind: " + d3.Kind);
    Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
    Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());
}

public void PadraoUTC(){
    DateTime d1 = DateTime.Parse("2000-08-20 13:07:58");
    DateTime d2 = DateTime.Parse("2000-08-20T13:07:58Z");

    Console.WriteLine("d1: " + d1);
    Console.WriteLine("d1 Kind: " + d1.Kind);
    Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
    Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
    Console.WriteLine();
    Console.WriteLine("d2: " + d2);
    Console.WriteLine("d2 Kind: " + d2.Kind);
    Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
    Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
    Console.WriteLine();
    // Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); ERRADO!
    Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
}
}