using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardProblems
{
    class Problem5
    {
        //member variables
        public string stringOfNumbers = "abc";
        public List<string> list = new List<string>();
        public List<double> intList = new List<double>();
       public List<string> multDigits = new List<string>();
        public string multiDigitNumber;

        //methods
        public void AddNumbersFromString()
        {
            
            char[] arrayOfNumbers = stringOfNumbers.ToCharArray();
            
            for (int i = 0; i <= arrayOfNumbers.Length - 1; i++)
            {
                if (char.IsDigit(arrayOfNumbers[i]))
                {
                    if (i == arrayOfNumbers.Length - 1)
                    {
                        list.Add(Convert.ToString(arrayOfNumbers[i]));
                    }
                    else if (char.IsWhiteSpace(arrayOfNumbers[i + 1]))



                    {
                        string charToInt = Convert.ToString(arrayOfNumbers[i]);
                        list.Add(charToInt);
                    }
                    else if (char.IsDigit(arrayOfNumbers[i + 1]))
                    {
                        
                        for(int j = i; j < arrayOfNumbers.Length -1 ; j++)
                        {
                            if (char.IsDigit(arrayOfNumbers[j]))
                            {


                                multDigits.Add(Convert.ToString(arrayOfNumbers[j]));
                            }
                            else
                            {
                                break;
                            }
                        }

                        for(int k = 0; k < multDigits.Count; k++)
                        {
                            multiDigitNumber = multiDigitNumber + multDigits[k];
                        }
                        i = i + multDigits.Count;
                        list.Add(multiDigitNumber);
                        multiDigitNumber = null;
                        multDigits = new List<string>();
                       

                    }
                   
                }
                else
                {

                }
                
            }


          

        }

        public void ConvertToInt()
        {
            foreach(string number in list)
            {
                double intNumber = Convert.ToDouble(number);
                intList.Add(intNumber);
            }
        }

        public void SortNumbers()
        {
            intList.Sort();
        }

       
        public void returnMinAndMax()
        {
            p;[ Console.WriteLine($"Minimum Value: {intList[0]}");
            Console.WriteLine($"Maximum Value: {intList[intList.Count - 1]}");

        }

      

    }
}
