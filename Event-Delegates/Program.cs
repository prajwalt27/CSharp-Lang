
//namespace EventsDelegates
//{
//    class Program
//    {

//        public static void Main(string[] args)
//        {

//            List<Animal> animalList = new List<Animal>();
//            List<int> numList = new List<int>();
//            numList.Add(20);

//            numList.Add(24);

//            animalList.Add(new Animal() { Name= "Dolly" });
//            animalList.Add(new Animal() { Name = "Kylo" });
//            animalList.Add(new Animal() { Name = "sullo" });
            
//            animalList.Insert(1,new Animal() { Name = "toky" });

//            animalList.RemoveAt(0);

//            foreach(Animal a in animalList)
//            {
//                Console.WriteLine(a.Name);
//            }

//            int x = 5, y = 4;
//            Animal.GetSum<int>(ref x, ref y);

//            string x1 = "5", y1 = "4";
//            Animal.GetSum<string>(ref x1, ref y1);


//            Rectangle<int>rec1= new Rectangle<int>(20,50);
//            Console.WriteLine(rec1.GetArea());

//            Rectangle<int> rec2 = new Rectangle<int>(10, 12);
//            Console.WriteLine(rec2.GetArea());

//            Arithmetic add, sub, addSub;

//            add = new Arithmetic(Add);
//            sub = new Arithmetic(subtract);
//            addSub = add + sub;

//            Console.WriteLine($"Add {7} & {10}");
//            add(7, 10);
//            Console.WriteLine($"Add & Subtract {19} &{4}");
//            addSub(19, 4);
//        }

//        public struct Rectangle<T>
//        {
//            private T width;
//            private T length;

//            public T Width
//            {
//                get
//                {
//                    return width;
//                }
//                set
//                {
//                    width = value;
//                }
//            }

//            public T Length
//            {
//                get
//                {
//                    return length;
//                }
//                set
//                {
//                    length = value;
//                }
//            }

//            public Rectangle(T w, T l)
//            {
//                width = w;
//                length = l;
//            }

//            public string GetArea()
//            {
//                double dlw = Convert.ToDouble(width);
//                double dll= Convert.ToDouble(length);

//                return string.Format($"{Width}*{Length}={dlw*dll}");
//            }
//        }


//        public delegate void Arithmetic(double num1, double num2);

//        public static void Add(double num1, double num2)
//        {
//            Console.WriteLine($"{num1}+{num2}= {num1+num2}");
//        }

//        public static void subtract(double num1, double num2)
//        {
//            Console.WriteLine($"{num1} +{num2}= {num1-num2}");
//        }

//    }
//}