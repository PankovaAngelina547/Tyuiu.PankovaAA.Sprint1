using Tyuiu.PankovaAA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #1                                                              *");
            Console.WriteLine("*  Тема: Операторы составного присваивания                                *");
            Console.WriteLine("*  Задание #04                                                            *");
            Console.WriteLine("*  Вариант #22                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("*  ,выполняет указанные расчёты и печатает результат на экране.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            int x, y;
            Console.WriteLine("Введите число х");
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y");
            y = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Sqrt(x*y)/(1+(x+2*y)^2)=" + ds.Calculate(x,y));
            Console.ReadKey();



        }
    }
}
