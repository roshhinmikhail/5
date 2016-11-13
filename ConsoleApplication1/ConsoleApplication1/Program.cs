using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, a1;
            Random rand = new Random();
            a1 = rand.Next(1, 11); 
            bool b = false;
            Console.WriteLine("Число от 1 до 10, у вас есть 3 попытки чтобы отгадать");
            for (int i = 0; i < 3; i++)     
            { Console.WriteLine("Попытка № " + (i+1) + " Введите число"); a = Convert.ToInt32(Console.ReadLine());
            if (a1 == a)
            { Console.WriteLine("Поздравляем, вы угадали!"); b = true; break; }
            else
            { if ((2 - i) > 0) { Console.WriteLine("Вы не угадали, осталось попыток : " + (2 - i)); } }
            }

            if (b == false) { Console.WriteLine("К сожалению вы не смогли угадать, число : " + a1); }
            Console.ReadLine();
            
        }
    }
}
