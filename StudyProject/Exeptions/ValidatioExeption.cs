using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Exeptions
{
    public class ValidatioExeption : ApplicationException
    {
        public ValidatioExeption()
        {
            Console.WriteLine("Sorry, but you entered start number  bigger than end number");
        }
        public ValidatioExeption(string val) : base(val)
        {
            Console.WriteLine(val);
        }
    }
}
