using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathException
{
    class MathMethods
    {
        static double result;
        public static double Multiply(double x, double y)
        {
            try
            {
                result = x * y;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (ArithmeticException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public static double Divide(double x, double y)
        {
            try
            {
                result = x / y;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (ArithmeticException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
