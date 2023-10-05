namespace BancoAprendizado.Conteudos.Entidades.Account
{
    //herança :
    public class BusinessAccount : Account{
        public double LoanLimit { get; set; }

        public BusinessAccount(){ //criar objetos sem passar dados
        }
//contrutor da subclasse
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance){
            LoanLimit = loanLimit;
        }

        public void Loan(double amount){
            if(amount <= LoanLimit)
                Balance += amount;
        }
    }
}