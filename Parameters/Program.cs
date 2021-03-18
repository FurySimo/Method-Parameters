using System;

namespace Parameters
{
    class Program
  

        
    {
     static void MyMethod1(string opt1, string opt2, string opt3 )
    { 
       Console.WriteLine("(a)"+opt1+
           "(b)"+opt2+
           "(c)"+opt3); 
    }
        static void MyMethod2(string opt4 = "Police")
        {
            Console.WriteLine(opt4);
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Are you interested in any of this?");
            MyMethod1("Engineering", " Doctor", "Teacher");
            Console.WriteLine("If you are not then we only have this for you.");
            MyMethod2();
        }
    }
}
