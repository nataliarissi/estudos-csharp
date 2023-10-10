using System.IO.Compression;

namespace BancoAprendizado.Conteudos.Entidades.Account
{
    public class Account{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance{ get; protected set; }

    public Account(){
    }

    public Account(int number, string holder, double balance){
        Number = number;
        Holder = holder;
        Balance = balance;
    }
  
    public virtual void Withdraw(double amount){
        //virtual para ser sobrescrito sobre as subclasses
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount){
        Balance += amount;
    }
 }
}