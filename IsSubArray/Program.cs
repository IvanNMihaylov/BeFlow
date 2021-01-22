using System;
using System.Security.Cryptography.X509Certificates;

namespace SubArray
{
    class Program
    {
        
        public static void Main()
        {
            //int[] arrayA = { 5, 1, 22, 25, 6, -1, 8, 10 };
            //int[] arrayB = {5, 1, 6, -1, 10 };

            Console.WriteLine("Please add numbers for the first array separated by a comma.");
            string numberStr1 = Console.ReadLine(); // "1,2,3,1,2,3,1,2 ...."
            string[] splitted = numberStr1.Split(',');
            int[] arrayA = new int[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                arrayA[i] = int.Parse(splitted[i]);
            }
            Console.WriteLine("Please add numbers for the second array separated by a comma.");
            string numberStr2 = Console.ReadLine(); // "1,2,3,1,2,3,1,2 ...."
            string[] split = numberStr2.Split(',');
            int[] arrayB = new int[split.Length];

            for (int j = 0; j < split.Length; j++)
            {
                arrayB[j] = int.Parse(split[j]);
            }


            if (IsSubArray.IssubArray(arrayA, arrayB))
            {

                Console.WriteLine("Are consistent! -> True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
