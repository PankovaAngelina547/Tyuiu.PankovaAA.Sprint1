using Tyuiu.PankovaAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task2.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #1                                                              *");
            Console.WriteLine("*  Тема: Арифметические операторы в С#                                    *");
            Console.WriteLine("*  Задание #2                                                             *");
            Console.WriteLine("*  Вариант #6                                                             *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна |ПИНб-25-1|                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите расстояние в метрах:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние в километрах =" + ds.ConvertMToKm(x));
            Console.ReadLine();
        }
    }
}

