using System;
using System.Collections.Generic;
using System.Text;

namespace introduction_to_csharp
{
    class HighestNumber
    {
        public void Hig(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("a is the highest number");
            }
            if (b > c && b > a)
            {
                Console.WriteLine("b is the highest number");
            }
            else 
            {
                Console.WriteLine("c is the highest number");
            }
        }
    }
}
