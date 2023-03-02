using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExample
{
    internal class PrimeRange
    {
        static bool isPrime(int n)
        {
            int c = 0;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
            if (c == 0)
            {
                return true;
            }
            return false;
        }
        public void Prime()
        {
            for (int i = 2; i <= 100; i++)
            {
                if (PrimeRange.isPrime(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
