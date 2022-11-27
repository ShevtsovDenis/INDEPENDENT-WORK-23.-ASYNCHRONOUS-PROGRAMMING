using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*1.    Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.*/

namespace INDEPENDENT_WORK_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);
            Console.ReadKey();
        }

        static void Sum(int n)//создаем метод для вычисления факториала
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void SumAsync(int n)//создаем асинхронный метод. Внутри создаем горячую задачу, в задаче через лямбда выражение создаем метод, который ничего не принимает и не возвращает и в нем вызываем метод вычисления.
        {
           await Task.Run(()=> Sum(n));
        }
    }
}
