namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{

    [TestMethod]
    public void ConvertDecimalToInt()
    {
       decimal valor = 278.60M;

       var cents = Money.ToCents(valor);
               
        Assert.AreEqual(27860, cents);
    }
}