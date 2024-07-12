//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EventsDelegates
//{
//    class Delegates
//    {       
//        public delegate void Calculator(double num1, double num2);

//        public static void Addition(double num1, double num2)
//        {
//            Console.WriteLine($"{num1}+{num2} = {num1+num2}");
//        }
//        public static void Subtraction(double num1, double num2)
//        {
//            if(num2>num1)
//            {
//                Console.WriteLine($"{num1}-{num2}= {num2 - num1}");
//                return;
//            }
//            Console.WriteLine($"{num1}-{num2}= {num1 - num2}");
//        }

//        public static void Multiplication(double num1, double num2)
//        {
//            Console.WriteLine($"{num1}*{num2} = {num1 * num2}");
//        }

//        static void Main(string[] args)
//        {
       
//            Calculator add, sub, mul;

//            //reference methods through reference objects
//            add = new Calculator(Addition);
//            sub = new Calculator(Subtraction);
//            mul = new Calculator(Multiplication);

//            Console.WriteLine($"Add: {18} & {9}  ");
//            add(18, 9);

//            Console.WriteLine($"Subtract: {34} & {7} ");
//            sub(34, 7);

//            Console.WriteLine($"Multiply: {4} & {3}");
//            mul(4, 3);

//        }
//    }
//}
