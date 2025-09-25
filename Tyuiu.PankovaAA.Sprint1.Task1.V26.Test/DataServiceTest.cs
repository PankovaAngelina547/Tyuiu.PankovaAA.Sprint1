using Tyuiu.PankovaAA.Sprint1.Task1.V26.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10, res);
        }
    }
}
