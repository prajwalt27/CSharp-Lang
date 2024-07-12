using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class Animal
    {
        private string name;

        // A protected field can be changed by  subclass directly
        protected string sound;

        // Inheritance -> "is-a" relationship, while an aggregation or delegate
        // represents a "Has-a" relationship like we have here with the AnimalIDInfo  object
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();   
        public void SetAnimalIdInfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }
        public void getAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}");
        }

        // overridden by subclasses must add override to the method in the subclass
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal() : this("No name","no sound") { }

        public Animal(string name="no name"): this(name,"No sound") {  }

        public Animal(string name,string sound) { Name = name; Sound = sound;}

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                    //Console.WriteLine("Cant use numbers in name");
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("sound is too long");
                }
                else
                {
                    sound = value;
                }
            }
        }




        //public void MakeSound()
        //{
        //    Console.WriteLine("{0} says {1}", name, sound);
        //}

        //public static int getNumAnimals()
        //{
        //    return numOfAnimals;
        //}

        //public void SetName(string name)
        //{
        //    if(!name.Any(char.IsDigit))
        //    {
        //        this.name = name;
        //    }
        //    else
        //    {
        //        this.name = "No name";
        //        Console.WriteLine("Name cant contains numbers");
        //    }
        //}

        //public string GetName()
        //{
        //    return name;
        //}




        // You can create inner classes that are
        // normally helper classes for the outer
        // class because it can access private
        // members of the outer class
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if((calc>= .18) && (calc <= .27)){
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //public string Owner { get; set; } = "No Owner";

        //public static int NumOfAnimals
        //{
        //    get { return numOfAnimals; }
        //    set { numOfAnimals += value; }
        //}

    }
}
