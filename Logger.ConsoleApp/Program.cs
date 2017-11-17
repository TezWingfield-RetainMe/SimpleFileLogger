using Logger.CL;
using Logger.CL.Interfaces;
using System;
using System.Threading.Tasks;

namespace Logger.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                double divideByZero = 1 / zero;
            }
            catch (DivideByZeroException ex)
            {
                new FileLogger().Log("Program.cs", "Main();", ex);
               
                //Handle Exception
            }
        }
    }
}
