namespace sum_of_digts
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }

}
