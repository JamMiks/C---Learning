using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
namespace Обучение
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int number = random.Next(1, 11);
            int guess = Convert.ToInt32(Console.ReadLine());
            if(number == guess)
            {
                Console.WriteLine("Угадал");
            }
            else
            {
                Console.WriteLine("Не угадал");
            }

        }
    }
}
