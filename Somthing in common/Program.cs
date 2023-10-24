

namespace Somthing_in_common
{

     class Program
    {
        static void Main()
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            foreach (string element2 in array2)
            {
                foreach (string element1 in array1)
                {
                    if (element2 == element1)
                    {
                        Console.Write($"{element2} ");
                        break; 
                    }
                }
            }

            Console.WriteLine(); 
        }
     }

   



}