using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

                result = MathMethods.Multiply(x, y);
                Console.WriteLine("Multiplication: " + result);
                result = MathMethods.Divide(x, y);
                Console.WriteLine("Division: " + result);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid input! Only numbers are allowed! {0}", e.Message);
                Console.WriteLine();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"Non-Inegers are not allowed! {0}", e.Message);
                Console.WriteLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Wrong format! Please use the correct formats! {0}", e.Message);
                Console.WriteLine();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Reference object not found! {0}", e.Message);
                Console.WriteLine();    
            }
            catch (IOException e)
            {
                Console.WriteLine($"I/O Error occured! {0}", e.Message);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong! Please check through everything! {0}", e.Message);
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
