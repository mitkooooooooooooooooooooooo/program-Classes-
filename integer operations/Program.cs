namespace integer_operations
{

    class Program
    {
        static void Main()
        {
           
           
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
             
            
            int num4 = int.Parse(Console.ReadLine()); 

            
            int sum = num1 + num2;
            int divisionResult = sum / num3;
           
            int finalResult = divisionResult * num4;

            
            Console.WriteLine(finalResult);

        }
    }

}