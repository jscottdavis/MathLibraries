using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 7;
            float c = 4.2f, d = 5.0f;

            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + SimpleMath.Add(a, b));
            Console.WriteLine(c.ToString() + " + " + d.ToString() + " = " + AdvancedMath.Add(c, d));
            Console.WriteLine(c.ToString() + " * " + d.ToString() + " = " + AdvancedMath.Multiply(c, d));

            Console.ReadLine();
        }
    }
}
