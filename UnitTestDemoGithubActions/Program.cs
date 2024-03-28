using System;

namespace UnitTestDemoGithubActions
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(3, 5)); // Output should be 8
        }
    }
}
