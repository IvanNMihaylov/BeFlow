using System;
using System.Collections.Generic;
using System.Text;

namespace SubArray
{
    class IsSubArray
    {
        public static bool IssubArray(int[] arrayA, int[] arrayB)
        {
            int startIndexB = 0;
            foreach (int n in arrayA)
            {
                int next = Array.IndexOf(arrayB, n);
                if (next == -1)
                {
                    startIndexB = next + 1;

                }
                else
                {
                    Console.WriteLine("Number : {0}", n);
                }

            }
            return true;
        }
    }
}
