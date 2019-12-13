using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public const int _retryCount = 3;

        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                RetryPattern.Test(retryCount: _retryCount);

            }



        }

    }
}
