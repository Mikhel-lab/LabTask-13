

using System;

namespace MulticastDelegateApp
{
    public delegate void Calculate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"Please input first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please input second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculate calculate = Multitask.Add;
            
            calculate += Multitask.Multiplication;
            calculate(num1, num2);
            
    }
}
}
