namespace _3._Nothing_in_common
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int targetSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    int num1 = int.Parse(input[i]);
                    int num2 = int.Parse(input[j]);
                    int sum = num1 + num2;

                    if (sum == targetSum)
                    {
                        Console.WriteLine($"{num1} {num2}");
                    }
                }

            }
        }

    }
}