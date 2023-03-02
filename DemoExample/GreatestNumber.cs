using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExample
{
    internal class GreatestNumber
    {
       public void great()
        {
            int a = 10, b = 15, c = 20;
            if(a>b && a>c)
            {
                Console.WriteLine("a is greater than b and c");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("b is greater than a and c");
            }
            else
            {
                Console.WriteLine("c is greater than a and b");
            }
        }
    }
}
