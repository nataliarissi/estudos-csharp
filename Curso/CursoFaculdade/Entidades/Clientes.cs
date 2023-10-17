namespace CursoFaculdade{
    public class Clientes{
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }
    
        public virtual void PagarImposto(float valor){
            Valor = valor;
            ValorImposto = Valor * 10 / 100;
            Total = Valor + ValorImposto;
        }
    }
}