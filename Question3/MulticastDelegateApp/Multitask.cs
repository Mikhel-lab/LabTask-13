using System;
namespace MulticastDelegateApp
{
    public class Multitask
    {
         static public void Add(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        static public void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
    }
}