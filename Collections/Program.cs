
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {

        static void Main(string[] args)
        {
            var Pandavas = new HashSet<String>();

            Pandavas.Add("Karna");
            Pandavas.Add("Udhishtir");
            Pandavas.Add("Bhim");
            Pandavas.Add("Arjun");
            Pandavas.Add("Nakul");
            Pandavas.Add("Sahadev");

            Pandavas.Add("Arjun"); //will not be added

            foreach (var pandav in Pandavas)
            {
                Console.WriteLine(pandav);
            }

        }
    }
}
