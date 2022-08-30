using AssignmentsCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssignmentOne assignmentOne = new AssignmentOne();
            int number = -20;
            int year = 2022;
            int number1 = 20, number2 = 60, number3 = 45;
            #region Question one => Using Conditional operator.. 
            Console.WriteLine($"{number} : IsPositive: {assignmentOne.IsPositive1(number)}");
            Console.WriteLine($"{number} : IsEven : {assignmentOne.IsEven1(number)}");
            Console.WriteLine($"{year} : IsLeap : {assignmentOne.IsLeap1(year)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} is : {assignmentOne.MaxInTwoNumber1(number1,number2)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} is : {assignmentOne.MinInTwoNumber1(number1, number2)}");
            Console.WriteLine($"Maximum number between {number1} and {number2} and {number3} is : {assignmentOne.MaxInThreeNumber1(number1, number2, number3)}");
            Console.WriteLine($"Minimum number between {number1} and {number2} and {number3} is : {assignmentOne.MinInThreeNumber1(number1, number2, number3)}");
            #endregion
            Console.ReadLine();


        }
    }
}
