using BancoInterface.Entities.Services;
using BancoInterface.Entities.Services.BrazilTaxService;

namespace BancoInterface.Entities.Services{
    class BrazilTaxService : ITaxService{
        public double Tax(double amount){
            if(amount <= 100){
                return amount * 0.2;
            }else{
                return amount * 0.15;
            }
        }
    }
}