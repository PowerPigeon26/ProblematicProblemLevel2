using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Calculator
{
    public class Calculator : ICalculable
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                return -1;
            }

            return Math.Round(x / y, 2);
        }

        public double Multiply(double x, double y)
        {
            return Math.Round(x * y, 2);
        }

        public double Subtract(double x, double y)
        {
            var result = x - y;
            return result;
        }
    }
}
