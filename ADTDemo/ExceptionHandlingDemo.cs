using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    class ExceptionHandlingDemo
    {
        public static void ExceptionHandlingDemoMain(string[] args)
        {
            try
            {
                Console.WriteLine("Some length process...");
                Random r = new Random();
                int rInt = r.Next(0, 2);

                if (rInt % 2 == 0)
                {
                    throw new Exception("Wrong number: " + rInt + "!");
                }

                Console.WriteLine("...Process complete!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred!");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("This will run no matter what!");
            }
        }
    }
}
