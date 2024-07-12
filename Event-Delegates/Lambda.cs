using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    class Lambda
    {

        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            doubleIt dblIt = x => x * 2;

            Console.WriteLine($"5*2 = {dblIt(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };

            var evenList = numList.Where(a => a%2==0).ToList();

            Console.WriteLine("Even numbers from the list:");
            foreach (var j in evenList) Console.WriteLine(j);

        }

    }
}
