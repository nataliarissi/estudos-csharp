namespace CursoFaculdade{
    class Program{
        static void Main(string[] args){

        float valorPagamento;
        Console.WriteLine("Informar Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Informar Endereço: ");
        string endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?: ");
        string escolha = Console.ReadLine();
        if(escolha == "f"){

        // --- Pessoa Física ----
        PessoaFisica pessoaFisica = new PessoaFisica();
        pessoaFisica.Nome = nome;
        pessoaFisica.Endereco = endereco;
        Console.WriteLine("Informar CPF: ");
        pessoaFisica.Cpf = Console.ReadLine();
        // pessoaFisica.Cpf = "880-117-980-00";
        Console.WriteLine("Informar RG: ");
        pessoaFisica.Rg = Console.ReadLine();
        Console.WriteLine("Informar Valor de Compra: ");

        valorPagamento = float.Parse(Console.ReadLine());
        pessoaFisica.PagarImposto(valorPagamento);

        Console.WriteLine("-------- Pessoa Física ---------");
        Console.WriteLine("Nome ..........: " + pessoaFisica.Nome);
        Console.WriteLine("Endereço ......: " + pessoaFisica.Endereco);
        Console.WriteLine("CPF ...........: " + pessoaFisica.Cpf);
        Console.WriteLine("RG ............: " + pessoaFisica.Rg);
        Console.WriteLine("Valor de Compra: " + 
        pessoaFisica.Valor.ToString("C"));
        Console.WriteLine("Imposto .......: " + 
        pessoaFisica.ValorImposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " + 
        pessoaFisica.Total.ToString("C"));
    }
        else if(escolha == "j"){

        // --- Pessoa Jurídica ---
        PessoaJuridica pessoaJuridica = new PessoaJuridica();
        pessoaJuridica.Nome = nome;
        pessoaJuridica.Endereco = endereco;
        Console.WriteLine("Informar CNPJ: ");
        pessoaJuridica.Cnpj = Console.ReadLine();
        Console.WriteLine("Informar IE: ");
        pessoaJuridica.InscricaoEstadual = Console.ReadLine();
        Console.WriteLine("Informar Valor de Compra: ");

        valorPagamento = float.Parse(Console.ReadLine());
        pessoaJuridica.PagarImposto(valorPagamento);

        Console.WriteLine("-------- Pessoa Jurídica ---------");
        Console.WriteLine("Nome ..........: " + pessoaJuridica.Nome);
        Console.WriteLine("Endereço ......: " + pessoaJuridica.Endereco);
        Console.WriteLine("CNPJ ..........: " + pessoaJuridica.Cnpj);
        Console.WriteLine("IE ............: " + pessoaJuridica.InscricaoEstadual);
        Console.WriteLine("Valor de Compra: " + 
        pessoaJuridica.Valor.ToString("C"));
        Console.WriteLine("Imposto .......: " + 
        pessoaJuridica.ValorImposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " + 
        pessoaJuridica.Total.ToString("C"));
        }
        else
            Console.WriteLine("Erro");
        }
    }   
}