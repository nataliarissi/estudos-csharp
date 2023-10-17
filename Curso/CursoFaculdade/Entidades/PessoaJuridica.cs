namespace CursoFaculdade{
    public class PessoaJuridica : Clientes{
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public virtual void PagarImposto(float valor){
            Valor = valor;
            ValorImposto = Valor * 20 / 100;
            Total = Valor + ValorImposto;
        }

    }
}