using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number seperated by commas");
            string input = Console.ReadLine();
            int[] arr = ArrayInput.TurnInputToArray(input);
            int response = ArrayInput.OperateOnArray(arr);

            Console.WriteLine($"The result is {response}");
            Console.ReadKey();
        }
    }
}

