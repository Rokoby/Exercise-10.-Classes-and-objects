using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите данные");
                int gradus = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                angle = new Angle(gradus, min, sec);
            }
            while (angle.isCorrect == false);

            double radians = angle.ToRadians();
            Console.WriteLine(radians);
            Console.ReadKey();
        }
    }
}
