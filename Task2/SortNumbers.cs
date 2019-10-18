using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject
{
    public class SortNumbers
    {
        public string GetSortNumbers(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return string.Join(string.Empty, array);
        }
    }
}
