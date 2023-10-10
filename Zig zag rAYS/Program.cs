namespace Zig_zag_rAYS
{
    using System;

    class Program
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
           
            for (int i = 0; i < n; i++)
            {
               
                string[] input = Console.ReadLine().Split();
                int firstNumber = int.Parse(input[0]);
                int secondNumber = int.Parse(input[1]);

                
                if (i % 2 == 0)
                {
                    firstArr[i] = firstNumber;
                    secondArr[i] = secondNumber;
                }
                else
                {
                    firstArr[i] = secondNumber;
                    secondArr[i] = firstNumber;
                }
            }

         
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }

}