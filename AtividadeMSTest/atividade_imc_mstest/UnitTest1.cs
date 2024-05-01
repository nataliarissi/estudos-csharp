namespace atividade_imc_mstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        Assert.AreEqual(imc_previsto, i.imc);
    }

    [DataTestMethod]
    [DataRow("Abaixo do peso")]
    [DataRow("Peso normal")]
    [DataRow("Sobrepeso")]
    [DataRow("Obesidade Grau I")]
    [DataRow("Obesidade Grau II")]
    [DataRow("Obesidade Grau III")]
    public void Teste_Categoria_IMC(String cat)
    {
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        i.Classificar_IMC();
        //MStest Assert.AreEqual
        Assert.AreEqual(i.categoria, cat);
    }

}