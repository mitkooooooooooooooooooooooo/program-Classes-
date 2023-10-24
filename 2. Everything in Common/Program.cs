namespace _2._Everything_in_Common
{
    

    class Program
    {
        static void Main()
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArry = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areIdentical = true;
            int differenceIndex = -1;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArry[i])
                {
                    areIdentical = false;
                    differenceIndex = i;
                    Console.WriteLine("Arrays are not identical.");
                    Console.WriteLine($"Found difference at {differenceIndex} index");
                    break;
                }
            }

            if (areIdentical)
            {
                Console.WriteLine("Arrays are identical.");
                int sum = firstArr.Sum();
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }


}