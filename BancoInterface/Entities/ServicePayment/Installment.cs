namespace BancoInterface.Entities.ServicePayment{
    public class Installment{
        public DateOnly DueDate;
        public double Amount;

        public Installment(DateOnly dueDate, double amount){
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString(){
            return DueDate.ToString("dd/MM/yyyy")
                + ":"
                + Amount;
        }
    }
}