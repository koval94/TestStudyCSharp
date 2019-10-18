using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class ConvertArray
    {
        public char[] ToCharArray(string numbers)
        {
            char[] arrayNumbers = new char[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arrayNumbers[i] = numbers[i];
            }
            return arrayNumbers;
        }
        public int[] ToIntArray(char[] array)
        {
            int[] intArray = new int[array.Length];
            for (int k = 0; k < array.Length; k++)
            {
                int.TryParse(array[k].ToString(), out intArray[k]);
            };
            return intArray;
        }
    }
}
