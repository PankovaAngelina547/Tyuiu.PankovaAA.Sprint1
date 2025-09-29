using Tyuiu.PankovaAA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            double wait = 0.024;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait,res);

        }
    }
}
