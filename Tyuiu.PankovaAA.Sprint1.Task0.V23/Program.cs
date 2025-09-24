// See https://aka.ms/new-console-template for more information
using Tyuiu.PankovaAA.Sprint1.Task0.V23.Lib;
namespace Tyuiu.PankovaAA.Sprint1.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #1                                                              *");
            Console.WriteLine("*  Тема: Базовые навыки работа в С#                                       *");
            Console.WriteLine("*  Задание #0                                                             *");
            Console.WriteLine("*  Вариант #23                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу, которая вычисляет выражение (15/(5*4))+1           *");
            Console.WriteLine("*  и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  (15/(5*4))+1                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.WriteLine();
        }
    }
}