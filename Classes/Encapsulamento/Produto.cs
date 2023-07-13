using System.Globalization;

namespace Banco.Natalia{
    public class Produto{
        
        private string _nome;
        private double _preco;
        private int _quantidade;

    public Produto(){
    }

    public Produto(string nome, double preco, int quantidade){
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome(){
        return _nome;
    }
//implementar somente o get corresponde a quantidade/preco nao poderem ser modificados
    
    public double GetPreco(){
        return _preco;
    }

    public int GetQuantidade(){
        return _quantidade;
    }

    public void SetNome(string nome){
        if (nome != null && nome.Length > 1)
        //Length siginica dizer tamanho da string
        _nome = nome;
    }

    public double ValorTotalEmEstoque(){
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int quantidade){
        _quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade){
        _quantidade -= quantidade;
    }

    //sobreposicao
        public override string ToString(){
            return _nome 
            + ", $ " 
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total; $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}