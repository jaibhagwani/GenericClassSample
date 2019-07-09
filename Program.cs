using System;

namespace GenericClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic compare method for string
            Console.Write("Enter First String: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter Second String: ");
            string str2 = Console.ReadLine();

            CompareSample<string> sampleStr = new CompareSample<string>();
            if (sampleStr.CompareValues(str1, str2))
            {
                Console.WriteLine("Input values are equal");
            }
            else
            {
                Console.WriteLine("Input values are not equal");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Generic compare method for integer
            Console.Write("Enter First Integer: ");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Integer: ");
            int val2 = Convert.ToInt32(Console.ReadLine());

            CompareSample<int> sampleInt = new CompareSample<int>();
            if (sampleInt.CompareValues(val1, val2))
            {
                Console.WriteLine("Input values are equal");
            }
            else
            {
                Console.WriteLine("Input values are not equal");
            }


            Console.ReadLine();
        }
    }
}
