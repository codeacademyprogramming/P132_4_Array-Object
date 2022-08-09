using System;

namespace _09082022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 4;

            //int[] numbers = { 34, 10, -5, 45 ,10,44};
            //int[] numbers = new int[4];
            int[] numbers = new int[4] { 10, -4, 35,100 };
           

            

            numbers[2] = 120; //34,10,120,45

            Console.WriteLine(numbers.Length);

            Console.WriteLine(numbers[3]);

            Console.WriteLine("index:");
          
            for(var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("last value:");
            Console.WriteLine(numbers[numbers.Length-1]);


            int k = 0;

            while (k < numbers.Length)
            {
                Console.WriteLine(numbers[k]);
                
                k++;
            }



            int num = 56;
            int[] points = { 10, num, 98, 145 };

            var sum = 0;

            for(var i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }

            Console.WriteLine("result:");
            Console.WriteLine(sum);

            string[] names = { "Abbas", "Abdulla", "Guldeste" };

            for(var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
          

        }
    }
}
