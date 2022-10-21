using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnil
{
    internal class CalculTreygolnik
    {

        public string checkTreug(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return "Треугольника с такими сторонами не существует!!!";
            }
            if (a == b && a == c && b == c)
            {
                return "Треугольник равносторонний!";
            }
            if (((a * a) == (b * b) + (c * c)) || ((b * b) == ((a * a) + (c * c)) || ((c * c) == (b * b) + (a * a))))
            {
                return "Треугольник прямоугольный!";
            }
            if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
            {
                return "Треугольник равнобедренный!";
            }
            return "Треугольник разносторонний!";
        }
    }
}
