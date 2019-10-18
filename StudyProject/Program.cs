using StudyProject.Exeptions;
using System;

namespace StudyProject
{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            var calculator = new Calculator();
    //            var inputConsole = new InputConsole();
    //            Console.Write("Please enter your first number here and press Enter button: ");
    //            var startNumber = inputConsole.GetNumber();
    //            Console.Write("Please enter your second number and press Enter button: ");
    //            var endNumber = inputConsole.GetNumberGreaterThan(startNumber);
    //            var result = calculator.Calculate(startNumber, endNumber);
    //            Console.WriteLine($"Yout total sum is: {result}");
    //        }
    //    }

    //    class Calculator
    //    {
    //        public int Calculate(int startNumber, int endNumber)
    //        {
    //            int result = 0;
    //            for (int k = startNumber; k <= endNumber; k++)
    //            {
    //                result = result + k;
    //            }
    //            return result;
    //        }
    //    }

    //    class InputConsole
    //    {
    //        public int GetNumber()
    //        {
    //            string result;
    //            int intResult;
    //            do
    //            {
    //                result = Console.ReadLine();
    //            }
    //            while (!int.TryParse(result, out intResult));
    //            return intResult;
    //        }
    //        public int GetNumberGreaterThan(int startNumber)
    //        {
    //            string result;
    //            int intResult;
    //            do
    //            {
    //                result = Console.ReadLine();
    //            }
    //            while (!int.TryParse(result, out intResult) || intResult <= startNumber);
    //            return intResult;
    //        }
    //    }

    //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            #region Calculator
            //var calculator = new Calculator();
            //try
            //{
            //    calculator.Calculate(21, 20);
            //}

            //catch (ValidatioExeption ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion



        }
    }

    class Calculator
    {
        public int Calculate(int startNumber, int endNumber)
        {
            int result = 0;
            if (startNumber > endNumber)
            {
                throw new ValidatioExeption("Sorry, but you entered start number  bigger than end number(xxxX)");
            }
                for (int k = startNumber; k <= endNumber; k++)
                {
                    result = result + k;
                }
             return result;
        }
    }
}
