using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardProblems
{
    class Problem1
    {


        //member Variables

        int[] newArray;
        int targetOutCome = 50;
        List<int> ArraysUsed = new List<int>();





        //constructor





        //method

        public void ReturnAnswers()
        {
            newArray = new int[4] { 5, 17, 77, 50 };
            
            foreach (int number in newArray)
            {
                for(int i = 0; i < 4; i++)
                if (number + newArray[i] == targetOutCome && number != newArray[i])
                {
                        
                        if (ArraysUsed.Contains(number))
                        {
                            //skip
                        }
                        else
                        {
                            ArraysUsed.Add(number);
                            ArraysUsed.Add(newArray[i]);
                            Console.WriteLine($"\n{Convert.ToString(number)},{newArray[i]}");
                        }
                }
            }
        }




    }
}
