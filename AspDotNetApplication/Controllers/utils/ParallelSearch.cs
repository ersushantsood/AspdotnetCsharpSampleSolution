using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AspDotNetApplication.Controllers.utils
{
   internal static class ParallelSearch
    {
        private static void MainParallelSearch(string[] args)
        {
            if(args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("*****Starting Main******");

            IOOperation();

            Console.WriteLine("*****End Main******");
            Console.ReadKey();
        }

        private static void IOOperation()
        {
            Console.WriteLine("*****Starting Operation******");

            var task1 = Delay(5000);

            Console.WriteLine("*****End Operation******");
        }

        private static int Delay(int ms)
        {
            Console.WriteLine($"Start delay for {ms}");
            Thread.Sleep(ms);
            Console.WriteLine($"End delay for {ms}");
            return ms;
        }
    }
}
