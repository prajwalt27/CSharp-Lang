using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {

        //static void Main(string[] args)
        //{

        //Animal billee = new Animal()
        //{
        //    Name = "Billee",
        //    Sound="meoow"
        //};

        //Dog don = new Dog()
        //{
        //    Name = "Don",
        //    Sound = "wouf",
        //    Sound2 = "grrr"
        //};

        //don.Sound = "Wooof";

        //billee.MakeSound();
        //don.MakeSound();

        //don.SetAnimalIdInfo(12345, "Praj t");
        //billee.SetAnimalIdInfo(12346, "P toundakar");

        //billee.getAnimalIDInfo();

        //Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
        //Console.WriteLine("Is my animal Healthy : {0}", getHealth.HealthyWeight(12,45));


        //Animal lion = new Animal()
        //{
        //    Name = "Shera",
        //    Sound = "roar"
        //};

        //Animal spot = new Dog()
        //{
        //    Name = "Spot",
        //    Sound = "woouuff",
        //    Sound2 = "Geerrr"
        //};

        //spot.MakeSound();

        //Animal cat = new Animal();
        //cat.SetName("bili");
        //cat.Sound = "Meow";
        //Console.WriteLine("the cat is name {0} and says {1}", cat.GetName(), cat.Sound);

        //cat.Owner = "Prajwal";
        //Console.WriteLine("{0} owner is {1}",cat.GetName(),cat.Owner);
        //Console.WriteLine("{0} shelter is {1}", cat.GetName(), cat.idNum);
        //Console.WriteLine("# of Animals:{0}", Animal.NumOfAnimals);

        //}


        //static void Main(string[] args)
        //{
        //    Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

        //    foreach(Shape i in shapes)
        //    {
        //        i.GetInfo();
        //        Console.WriteLine("{0}  Area: {1:f2}",i.Name, i.Area());

        //        Circle testC = i as Circle;
        //        if(testC == null)
        //        {
        //            Console.WriteLine("This isnt a circle");
        //        }

        //        if(i is Circle)
        //        {
        //            Console.WriteLine("this isnt a rectangle");
        //        }
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    Vehicle Tesla = new Vehicle("X", 4, 240);
        //    if(Tesla is IDrivable)
        //    {
        //        Tesla.Move();
        //        Tesla.Stop();
        //    }
        //    else
        //    {
        //        Console.WriteLine("The {0} cant be driven", Tesla.Brand);
        //    }
        //}

        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();

            powBut.Execute();
            powBut.Undo();

           
        }
    }
}
          


    

