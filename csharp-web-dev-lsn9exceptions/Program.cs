using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int point = 0;
            if (fileName.Contains(".cs"))
            {
                point = 1;
                return point;
            }
            else if (fileName == null | fileName == "")
            {
                throw new ArgumentNullException();

            } else if (!fileName.Contains(".cs"))
            {
                point = 0;
                return point;
            } 
            return point;
        }


        static void Main(string[] args)
        {
            double a = 4, b = 0;
            double result;

            try
            {
                result = Divide(a, b);
                Console.WriteLine("%{a} divided by {b} equals {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by 0");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (var kvp in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(kvp.Value));
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Cannot be null!");
                }

            }


        }
    }
}
