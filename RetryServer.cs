using System;

namespace ConsoleApp4
{
    public class RetryServer
    {

        private readonly Random random = new Random();

        public string Get()
        {
            if (random.Next() % 3 == 0)
                throw new Exception("Network problem...");
            return "Result";
        }
    }
}
