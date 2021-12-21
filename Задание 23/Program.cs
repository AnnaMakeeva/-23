using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static int Factorial()
        {
            Console.WriteLine("Factorial начал работу");
            Console.WriteLine("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("Факториал: {0}", factorial);
           Console.WriteLine("Factorial закончил работу");
            return (factorial);
        }
        static void Main(string[] args)
        {
            
            int r=FactorAsync().Result;
            Console.WriteLine("Main окончил работу");
            Console.ReadKey();
        }
        static async Task<int> FactorAsync()
        {
            Console.WriteLine("FactorAsync начал работу");

            int result=await Task.Run(() => Factorial());

            Console.WriteLine("FactorAsync окончил работу");

            return result;
        }
    }
}
