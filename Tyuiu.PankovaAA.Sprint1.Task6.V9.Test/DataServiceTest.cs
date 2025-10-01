using System.Security.Cryptography.X509Certificates;
using Tyuiu.PankovaAA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            Assert.AreEqual("ohel", DataService.MoveLastToStart("hello"));
            Assert.AreEqual("рми", DataService.MoveLastToStart("мир"));
            Assert.AreEqual("а", DataService.MoveLastToStart("а"));
            Assert.AreEqual("", DataService.MoveLastToStart(""));
            Assert.AreEqual("!Привет", DataService.MoveLastToStart("Привет!"));

        }

        [TestMethod]
        public void TransformWholeText_PreserveWhitespace()
        {
            DataService ds = new DataService();
            string input = "мир и труд";
            string expected = "рми и дтру";
            Assert.AreEqual(expected, ds.Calculate(input));
        }
        [TestMethod]
        public void NullInput_ReturnsNull()
        {
            DataService ds = new DataService();
            Assert.IsNull(ds.Calculate(null));
        }
    }
}



