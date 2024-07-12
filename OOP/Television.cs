using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class Television: IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The Tv is off");
        }

        public void On()
        {
            Console.WriteLine("The Tv is on");
        }
        public void VolumeDown()
        {
            if(Volume!=0)
            {
                Volume--;
            }
            Console.WriteLine($"Volume is at {Volume}");
        }
        public void VolumeUp()
        {
            if (Volume!=100)
            {
                Volume++;
            }
            Console.WriteLine("Volume is at {Volume}");
        }

    }
}
