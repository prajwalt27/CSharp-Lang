

//variables

//int num = 28;
//double cgpa = 9.43;
//char letter = 'P';
//bool isCorrect = true;
//string name = "Prajwal";

//Console.WriteLine(num+ " "+name+" "+cgpa+" "+isCorrect);


//if-else

//using System;
//public class IfExample
//{
//    public static void Main(string[] args)
//    {
//Console.WriteLine("Enter a number:");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("It is even number");
//}
//else
//{
//    Console.WriteLine("It is odd number");
//}

//Console.WriteLine("Enter marks: ");
//int marks = Convert.ToInt32(Console.ReadLine());

//switch (marks)
//{
//    case 75:
//        Console.WriteLine("Ok!");break;
//    case 85:
//        Console.WriteLine("Good marks!");break;
//    case 95:
//        Console.WriteLine("Better marks!");break;
//    case 100:
//        Console.WriteLine("Best marks!"); break ;
//}


//string[] technologies = new string[5];

//Console.WriteLine("Enter any 5 technologies: ");

//for (int i = 0; i < 5; i++)
//{
//    string tech = Console.ReadLine();
//    technologies[i] = tech;
//}

//Console.WriteLine("Entered Technologies-->");

//foreach (string i in technologies)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Happy learning!");



//int[] arr = new int[7];

//Console.WriteLine("Enter any 7 numbers in any order");

//for(int i=0;i<7;i++)
//{
//    int num= Convert.ToInt32(Console.ReadLine());
//    arr[i] = num;
//}

//Console.WriteLine("Sorted Array-->");
//Array.Sort(arr);
//foreach(int it in arr)
//{
//    Console.Write(it+" ");
//}

//Console.WriteLine("\n Max number: "+ arr.Max());
//Console.WriteLine("Min number: " + arr.Min());
//Console.WriteLine("Sum of numbers: "+arr.Sum());


//        Console.WriteLine("Multi Deimensional Array!");
//        int[,] arr = new int[3, 3];
//        arr[0, 1] = 11;
//        arr[1, 2] = 23;
//        arr[2, 0] = 56;

//        for (int i = 0; i < 3; i++)
//        {
//            for(int j = 0; j < 3; j++)
//            {
//                Console.Write(arr[i,j]+" ");
//            }
//            Console.WriteLine();
//        }

//    }
//}

//public class Employee
//{
//    public int id;
//    public string name;
//    public float salary;

//    public Employee(int i,string n, float s)
//    {
//        id = i;
//        name = n;
//        salary = s;
//    }

//    public void display()
//    {
//        Console.WriteLine(id+" "+name+ " "+salary);
//    }

//    ~Employee() { Console.WriteLine("Constructor Invoked!"); }
//}
//class TestEmployee
//{  public static void Main(string[] args)
//    {
//        Employee emp1= new Employee(1,"ram",999999f);
//        Employee emp2 = new Employee(2,"shyam",999997f);
//        emp1.display();
//        emp2.display();
//    }
//}



//Exceptional Handling

//using System.Collections.Concurrent;

//double num1 = 5;
//double num2 = 0;

//static double DoDivision(double x, double y)
//{
//    if (y == 0)
//    {
//        throw new System.DivideByZeroException();
//    }
//    return x / y;
//}

//try
//{
//    Console.WriteLine("5/0 = {0}",DoDivision(5,0));
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("you cant divide by zero");
//    Console.WriteLine(ex.GetType().Name);
//    Console.WriteLine(ex.Message);
//}
//catch(Exception ex)
//{
//    Console.WriteLine("An Error occured");
//    Console.WriteLine(ex.GetType().Name);
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Cleaning Up");
//}


//String Builder

//using System.Globalization;
//using System.Text;
//class Practice 
//{
//      static void Main(string[] args)
//      {
//        StringBuilder sb1= new StringBuilder("Random Text");
//        StringBuilder sb2 = new StringBuilder("More stuff is very important",256);

//        Console.WriteLine("Capacity: {0}", sb2.Capacity);
//        Console.WriteLine("Length: {0}", sb2.Length);

//        sb2.AppendLine("\n More important text");

//        CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
//        String BestCustomer = "Prajwal";

//        sb2.AppendFormat(enUs, "Best Customer: {0}", BestCustomer);
//        Console.WriteLine(sb2.ToString());

//        sb2.Replace("text", "characters");
//        Console.WriteLine(sb2.ToString());

//        sb2.Clear();
//        sb2.Append("random text");
//        Console.WriteLine(sb2.Equals(sb2));

//        sb2.Insert(11, " that's great");
//        Console.WriteLine(sb2.ToString());

//        sb2.Remove(11, 7);
//        Console.WriteLine(sb2.ToString());
//    }
//}


//--- Functions -----
// <Access Specifier> <Return type> <Method name> (Parameters)
//{ <Body> }

// Access specifier determinse whether the function can 
// be called frmo another class

//public:  can be accessed from another class
//private: cant be accessed from another class
//protected : cant be accessed by class and derived classes


//class Practice 
//{
//    private static void sayhello()
//    {
//        string name = "";
//        Console.WriteLine("what is your name: ");
//        name = Console.ReadLine();
//        Console.WriteLine("Hello {0}", name);
//    }

//    static double GetSum(double x=1, double y=1)
//    {
//        return x + y;
//    }

//    static void DoubleIt(int x, out int solution)
//    {
//        solution = x * 2;
//    }

//    static void Main(string[] args)
//     {
//        int solution;
//        DoubleIt(15, out  solution);
//        Console.WriteLine("15*2={0}",solution);

//    }
//}


//Datetime
class Practice
{

    static void Main(string[] args)
    {
        DateTime awesomeDate = new DateTime(2024, 7, 10);
        Console.WriteLine("Day of the week: {0}", awesomeDate.DayOfWeek);
        awesomeDate = awesomeDate.AddDays(3);
        awesomeDate = awesomeDate.AddMonths(1);
        awesomeDate = awesomeDate.AddYears(1);

        Console.WriteLine("New date: {0}", awesomeDate.Date);

        TimeSpan lunchtime = new TimeSpan(12, 30, 0);
        lunchtime = lunchtime.Subtract(new TimeSpan(0, 15, 0));

        Console.WriteLine("New Time:{0}", lunchtime.ToString());


    }
}