using StudyProject;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SortNumbers
            var sortNumbers = new SortNumbers();
            var inputConsole = new InputConsole();
            var convertArray = new ConvertArray();
            string parametr;
            try
            {
                parametr = inputConsole.GetNumberAsString();
            }
            catch (MyExeption ex)
            {
                parametr = inputConsole.GetNumberAsString();
            }
            char[] charArray = convertArray.ToCharArray(parametr);
            int[] intArray = convertArray.ToIntArray(charArray);
            string result = sortNumbers.GetSortNumbers(intArray);
            Console.WriteLine(result);
            #endregion
        }
    }
}
