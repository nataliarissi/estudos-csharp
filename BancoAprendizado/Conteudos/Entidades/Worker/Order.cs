
using BancoAprendizado.Conteudos.Entidades.Enums;

namespace BancoAprendizado.Conteudos.Entidades.Worker
{
    class Order{
//Enumerações

    public int Id {get; set;}
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString(){
        return Id + ", " + Moment + ", " + Status;
    }

    }
}
