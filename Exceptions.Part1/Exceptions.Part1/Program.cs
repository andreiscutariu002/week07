using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Part1
{
    class Program
    {
        static void Main()
        {
            try
            {
                RunProgram();
            }
            catch (Exception e)
            {
                var message = e.Message; // message
                var stackTrace = e.StackTrace;
                var innerExc = e.InnerException;

                Console.WriteLine(e);
            }
        }

        private static void RunProgram()
        {
            try
            {
                string s = Console.ReadLine();
                var x = int.Parse(s);

                if (x == 0)
                {
                    throw new InvalidOperationException("Number is 0!!!");
                }

                Console.WriteLine("Valid integer number {0}.", x);
            }
            catch (FormatException e)
            {
                Console.WriteLine("XXX - Format exception !!!");

                throw new Exception("Some exception", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Here 2 - OverflowException: {e.Message}");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"Here - OverflowException: {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"InvalidOperationException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        //static void Main()
        //{
        //    string s = Console.ReadLine();

        //    try
        //    {
        //        var x = int.Parse(s);

        //        Console.WriteLine("Valid integer number {0}.", x);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Invalid integer number!");
        //    }
        //    catch (OverflowException)
        //    {
        //        Console.WriteLine("The number is too big for int!");
        //    }
        //}
    }
}
