// See https://aka.ms/new-console-template for more information
using Tyuiu.PankovaAA.Sprint1.Task1.V26.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #1                                                              *");
            Console.WriteLine("*  Тема: Организация ввода/вывода в консольных приложениях                *");
            Console.WriteLine("*  Задание #1                                                             *");
            Console.WriteLine("*  Вариант #26                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна |ПИНб-25-1|                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("*  вычисляет результат по формуле 5*x/(2+y) и печатает его на экране.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  5*x/(2+y)                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:");
            x=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
