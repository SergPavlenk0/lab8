using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab8
{
    public delegate double del(int a, int b);
    public class Calculator
    {
        public del Addition = (a, b) => a + b;
        public del Subtraction = (a, b) => a - b;
        public del Multiplication = (a, b) => a * b;
        public del Division = (a, b) =>
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        };
    }
}
