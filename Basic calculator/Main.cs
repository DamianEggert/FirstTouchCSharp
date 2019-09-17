using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number one: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write operator (+, -, *, /, %): ");
            string op = Console.ReadLine();
            Console.Write("Write number two: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op.Equals("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op.Equals("-"))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op.Equals("*"))
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op.Equals("/"))
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op.Equals("%"))
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }

            Console.ReadLine();
        }
    }
}
