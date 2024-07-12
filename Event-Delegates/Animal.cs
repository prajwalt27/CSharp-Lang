using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegates
{
    class Animal
    {
            public string Name{ get; set;}
            public Animal(string name="No Name") { name = name; }

           public static void GetSum<T>(ref T num1, ref T num2)
           {
             double dblx = Convert.ToDouble(num1);
             double dbly = Convert.ToDouble(num2);
            Console.WriteLine($"{dblx} + {dbly} = {dblx+ dbly}");
            }
        
    }
}

