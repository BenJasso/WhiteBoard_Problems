using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //member variables
            Problem1 problem1 = new Problem1();
            Problem3 problem3 = new Problem3();
            Problem4 problem4 = new Problem4();


            //problem1
            //problem1.ReturnAnswers();
            //Console.ReadLine();


            //problem3.CheckForSequence();
            //Console.WriteLine(problem3.CheckForSequence());
            //Console.ReadLine();

            Console.WriteLine($"Your sum of negative numbers is {problem4.SumOfNegativeNumbers()}");
            
            Console.WriteLine($"Your count of positive numbers in the list is {problem4.CountOfPositiveNumbers()}");
            Console.ReadLine();


        }
    }
}
