using Tyuiu.PankovaAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(0,004, res);


        }
    }
}
