using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuesOfDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maximum number of consecutive 1's in the binary representation of any numbers.
            BinaryMaxOnes();
        }
    
        private static void BinaryMaxOnes()
        {
            int input;
            Console.WriteLine("Enter number : ");
            input = Convert.ToInt32(Console.ReadLine());
            string binary = ConvertToBinary(input);
            Console.WriteLine($"Binary Representation of {input} is : {binary}.");
            int count = CountOnes(binary);
            Console.WriteLine($"Maximum number of consecutive 1's : {count}.");
            Console.ReadLine();
        }
        private static int CountOnes(string binary)
        {
            int count = 0, maxCount=0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                }
                else
                {
                    if (maxCount <= count)
                    {
                        maxCount = count;
                        count = 0;
                    }
                }
            }
            return count >= maxCount ? count : maxCount;
             
        }

        private static string ConvertToBinary(int input)
        {
            string tempresult=String.Empty;
            string result = "";
            while (input > 0)
            {
                tempresult += Convert.ToString(input % 2);
                input /= 2;
            }

            for(int i = tempresult.Length-1; i >= 0; i--)
            {
                result += tempresult[i];
            }

            return result;
        }
    }
}
