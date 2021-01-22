using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BFlow_Tasks
{
    class DuplicateCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count;

            char[] stringInput = input.ToCharArray();

            Console.WriteLine("Duplicate characters in a given string:");

            for (int i = 0; i < stringInput.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < stringInput.Length; j++)
                {
                    if (stringInput[i] == stringInput[j] && stringInput[i]!=' ')
                    {
                        count++;
                        stringInput[j] = '0';
                    }
                }

                if (count > 1 && stringInput[i] != '0')
                {
                   Console.WriteLine("\"{0}\" occurs {1} times", stringInput[i], count);
                }

            }
        }
    }
}
