using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardProblems
{
    class Problem4
    {
        //member variables
        int[] randomNumberList = new int[11] { 7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21 };
        List<int> negativeNumbers;
        List<int> positiveNumbers;

        //methods

        public int SumOfNegativeNumbers()
        {
            negativeNumbers = new List<int>();
            foreach(int number in randomNumberList)
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
               

            }
            return negativeNumbers.Sum();
           

        }

        public int CountOfPositiveNumbers()
        {
            positiveNumbers = new List<int>();
            foreach (int number in randomNumberList)
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                }
            }
            return positiveNumbers.Count;
            

        }
    }
}
