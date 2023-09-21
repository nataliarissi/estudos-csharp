//timespan representa durações
using System;

public class IntervaloTempo{
public void ComandosTimeSpan(){
    
    // TimeSpan t1 = new TimeSpan(0, 1, 30);

    // Console.WriteLine(t1);
    // Console.WriteLine(t1.Ticks);

    TimeSpan t1 = new TimeSpan();
    TimeSpan t2 = new TimeSpan(900000000L);
//com construtor vazio, tudo zerado
    TimeSpan t3 = new TimeSpan(2, 11, 21);
    TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
    TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

    Console.WriteLine(t1);
    Console.WriteLine(t2);
    Console.WriteLine(t3);
    Console.WriteLine(t4);
    Console.WriteLine(t5);

}

public void ComandosTimeSpanDerivados(){

    TimeSpan t1 = TimeSpan.FromDays(1.5);
    TimeSpan t2 = TimeSpan.FromHours(1.5);
    TimeSpan t3 = TimeSpan.FromMinutes(1.5);
    TimeSpan t4 = TimeSpan.FromSeconds(1.5);
    TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
    TimeSpan t6 = TimeSpan.FromTicks(900000000L);

    Console.WriteLine(t1);
    Console.WriteLine(t2);
    Console.WriteLine(t3);
    Console.WriteLine(t4);
    Console.WriteLine(t5);
    Console.WriteLine(t6);
//calcular multa - juros
}

public void PropriedadesTimeSpan(){
    // TimeSpan t1 = TimeSpan.MaxValue;
    // TimeSpan t2 = TimeSpan.MinValue;
    // TimeSpan t3 = TimeSpan.Zero;

    // Console.WriteLine(t1);
    // Console.WriteLine(t2);
    // Console.WriteLine(t3);

    TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

    Console.WriteLine(t);

    Console.WriteLine("Days: " + t.Days);
    Console.WriteLine("Hours: " + t.Hours);
    Console.WriteLine("Minutes: " + t.Minutes);
    Console.WriteLine("Milliseconds: " + t.Milliseconds);
    Console.WriteLine("Seconds: " + t.Seconds);
    Console.WriteLine("Ticks: " + t.Ticks);

    Console.WriteLine("TotalDays: " + t.TotalDays);
    Console.WriteLine("TotalHours: " + t.TotalHours);
    Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
    Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
    Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
}

public void OperacoesTimeSpan(){
    TimeSpan t1 = new TimeSpan(1, 30, 10);
    TimeSpan t2 = new TimeSpan(0, 11, 7);

    TimeSpan soma = t1.Add(t2);
    TimeSpan diferenca = t1.Subtract(t2);
    TimeSpan multiplicacao = t2.Multiply(2.0);
    TimeSpan divisao = t2.Divide(2.0);

    Console.WriteLine(soma);
    Console.WriteLine(diferenca);
    Console.WriteLine(multiplicacao);
    Console.WriteLine(divisao);
}
}