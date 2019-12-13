using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp4
{
    internal static class RetryPattern
    {
        internal static void Test(int retryCount)
        {
            var server = new RetryServer();
            var currentRetry = 0;

            do
            {
                try
                {
                    currentRetry++;
                    server.Get();
                    break;
                }
                catch (Exception ex) when (currentRetry <= retryCount)
                {
                    Trace.WriteLine(ex.Message);
                }

                Thread.Sleep(300);
            } while (true);

            Console.WriteLine("Operation complete!");
            Console.WriteLine($"Попыток: {currentRetry}");

        }
    }
}