using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class InputConsole
    {
        char[] stringAsCharArray;
        int[] charArrayAsIntArray;
        public string GetNumberAsString()
        {
            string result = Console.ReadLine();
            charArrayAsIntArray = new int[result.Length];
            stringAsCharArray = new char[result.Length];


            //var charArray = result.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                stringAsCharArray[i] = result[i];
            }

            for(int k = 0; k < stringAsCharArray.Length; k++)
            {
                var temp = int.TryParse(stringAsCharArray[k].ToString(), out charArrayAsIntArray[k]);
                if(temp == false)
                {
                    throw new MyExeption();
                }
            }

            return result;
        }
    }
}
