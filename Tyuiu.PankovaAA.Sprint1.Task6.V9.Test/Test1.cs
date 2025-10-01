using Tyuiu.PankovaAA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task6.V9.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void ValueExpression()
    {
        DataService ds = new DataService();
        Assert.AreEqual("тприве рми", ds.MoveLetterToStart("привет мир"));
    }
}
