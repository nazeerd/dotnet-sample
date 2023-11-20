using introduction_to_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqsample1
{
    class program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var mixedsyntax = (from obj in list
                               select obj).Max();



           // Console.WriteLine("MaxValue value= " + mixedsyntax);

                //Console.ReadLine();

            Addition sum = new Addition();
            int A = sum.Add(2, 3);


            Console.WriteLine(A);
            Console.ReadLine();



        }
    }
}







