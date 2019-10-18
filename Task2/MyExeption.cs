using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class MyExeption : ApplicationException
    {
        public MyExeption()
        {
            Console.WriteLine("Plese enter your number again... It seems as you entered text instead mumbers");
        }
        public MyExeption(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
