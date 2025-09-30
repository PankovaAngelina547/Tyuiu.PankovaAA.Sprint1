using Tyuiu.PankovaAA.Sprint1.Task7.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double wait = 0.875;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait,res);

        }
    }
}
