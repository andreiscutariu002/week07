using System;
using System.Runtime.Serialization;

namespace Exceptions.Part2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var i = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    throw new WanstomeMathV2Exception();
                }
            }
            catch (WanstomeMathV2Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (WantsomeBaseException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public class WantsomeBaseException : ArithmeticException
    {

    }

    [Serializable]
    public class WanstomeMathV2Exception : WantsomeBaseException
    {
    }

    [Serializable]
    public class MyException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}