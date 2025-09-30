using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PankovaAA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int x)
        {
            double res = (x / 100) % 10;
            return (int) res;
        }

    }
}
