using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardProblems
{
    class Problem3
    {

        //member variables
        List<int> listOfNumbers = new List<int> {17, 15, 20, 19, 21, 16, 18};
        public bool isCompatible;


        //method
        public bool CheckForSequence()
        {
            listOfNumbers.Sort();


            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                int firstNumber = listOfNumbers[i];
                int secondNumber = listOfNumbers[i+1];
                if(firstNumber == secondNumber - 1)
                {
                    isCompatible = true;
                }
                else
                {
                    isCompatible = false;
                    break;
                }
            }

            if (isCompatible == true)
            {
                return true;
            }
            else if (isCompatible == false)
            {
                return false;
            }
            else
            {
                return false;
            }
            
        }
    }
}
