namespace BancoAprendizado.Conteudos.Entidades.Account
{
    //herança :
    sealed class SavingAccount : Account{
// sealed evita que a classe seja herdada
// proteger regras de negócio
        public double InterestRate { get; set; }

        public SavingAccount(){
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance){
        InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount){
            // Balance -= amount;
            base.Withdraw(amount);
            Balance -= 2.0;
            //base - reaproveitar a operação da super classe e adicionar o solicitado
        }
    //úlitmo método não pode ser sobrescrito novamente

    // normalmente selar métodos sobrepostos para que não tenha múltiplas inconsistências
    }
}