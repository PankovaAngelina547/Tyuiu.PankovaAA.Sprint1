using Tyuiu.PankovaAA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 130985;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            int result = Convert.ToInt32(res);
            int wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}
