using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;
namespace Обучение
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 1 до 10");
            bool guessed = false;
            Random random = new Random();
            int number = random.Next(1, 11);
            for (int i = 1; i <= 3; i++)
            {
                
                Console.WriteLine("Попытка " + i);
                int guess = Convert.ToInt32(Console.ReadLine());
                if (number == guess)
                {
                    Console.WriteLine("Угадал");
                    guessed = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Не угадал");
                    
                }

               
            }
            if (guessed == false)
            {
                Console.WriteLine("Было загадано число " + number);
            }

        }
    }
}
