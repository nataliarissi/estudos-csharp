using System.Globalization;

namespace Banco.Natalia{
    public class Produto{
        
        public string Nome;
        public double Preco;
        public int Quantidade;
        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
    }
//construtor
    public Produto(string nome, double preco, int quantidade){
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
//nome de parametro minusculo

    public Produto(string nome, double preco){
        Nome = nome;
        Preco = preco;
    //  Quantidade = 0; - nao precisa atribuir, ele ja comeca com valor zero
    }

    public void AdicionarProdutos(int quantidade){
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade){
        Quantidade -= quantidade;
    }

    //sobreposicao
        public override string ToString(){
            return Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total; $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}