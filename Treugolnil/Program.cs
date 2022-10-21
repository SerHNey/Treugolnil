using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnil
{
    internal class Program
    {
        public static int checkNumber(string numb)
        {
            try
            {
                int num = int.Parse(numb);
                if (num != 0 && num > 0 && num < 1000)
                {
                    return num;
                }
                else
                    Console.WriteLine("Число не подошло, и будет замененно на 0");
                    return 0;

            }
            catch (FormatException) { return 0; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника");
            
            Console.WriteLine("Первая сторона: ");
            int wallOne = checkNumber(Console.ReadLine());
            
            Console.WriteLine("Вторая сторона: ");
            int wallTwo = checkNumber(Console.ReadLine());

            Console.WriteLine("Третья сторона: ");
            int wallThree = checkNumber(Console.ReadLine());

            CalculTreygolnik treygolnik = new CalculTreygolnik();
            String result = treygolnik.checkTreug(wallOne, wallTwo, wallThree);
            Console.WriteLine($"{result}");

            Console.ReadKey();
        }
        
    }
}
