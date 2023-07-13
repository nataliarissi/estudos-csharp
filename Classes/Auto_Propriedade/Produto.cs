using System.Globalization;

namespace Banco.Natalia{
    public class Produto{
        
        private string _nome;
        public double Preco {get; private set;}
        public int Quantidade {get; private set;}
// escrever prop e dar tab - recebe a estrutura pronta
    public Produto(){
    }

    public Produto(string nome, double preco, int quantidade){
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
//propriedade com get/set
    public string Nome{
        get{return _nome}
        set{
            if (value != null && value.Length > 1)
        _nome = value;
            }
    //value e o parametro que chegaria no metodo set
    }

    public double ValorTotalEmEstoque(){
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade){
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade){
        Quantidade -= quantidade;
    }

    //sobreposicao
        public override string ToString(){
            return _nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total; $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}