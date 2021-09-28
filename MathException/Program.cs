using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathException
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0;
            double result = 0;
            Console.WriteLine("Enter 2 numbers: ");
            try
            {
                Console.Write("First Number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Second Number: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalide input! Only numbers are allowed!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Non-Inegers are not allowed!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong! Please check through everything!");
                Console.WriteLine();
            }
            result = MathMethods.Multiply(x, y);
            Console.WriteLine("Multiplication: " + result);
            result = MathMethods.Divide(x, y);
            Console.WriteLine("Division: " + result);
            Console.ReadLine();
        }
    }
}
