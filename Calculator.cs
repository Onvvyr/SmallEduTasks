using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Power(int a, int b)
        {
            return a ^ b;
        }
    }
}