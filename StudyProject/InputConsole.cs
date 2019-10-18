using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject
{
    public class InputConsole
    {
        public int GetNumber()
        {
            string result;
            int intResult;
            do
            {
                result = Console.ReadLine();
            }
            while (!int.TryParse(result, out intResult));
            return intResult;
        }
        public int GetNumberGreaterThan(int startNumber)
        {
            string result;
            int intResult;
            do
            {
                result = Console.ReadLine();
            }
            while (!int.TryParse(result, out intResult) || intResult <= startNumber);
            return intResult;
        }
    }
}
