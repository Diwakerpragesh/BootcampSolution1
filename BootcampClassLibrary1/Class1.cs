using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace BootcampClassLibrary1
{
/*
    public class SimpleDataClass
    {
     

    }
*/
    public class Class1
    {
        /*
        public string s1 { get; set; }
        public string s2 { get; set; }
        public string s3 { get; set; }
        public static void DoSomething()   // STATIC FUNCTION
        {
            Console.WriteLine("This is a Static Function");
        }

        public void DoSomethingElse()   // NON-STATIC / Instance function
        {
            Console.WriteLine("Thi is a Non-Static Function");
        }

        public DateTime ReturnAValue()
        {
            return DateTime.Now;    
        }
        public void AcceptSomeInputs(int i, string s)
        {
            Console.WriteLine(s);
        }

        public void AcceptSomeInputs(int i)
        {
            Console.WriteLine(i);
        }

        public void ProvideDefaults(int i=0,string s="Hello")
        {
            Console.WriteLine("default integer Value "+i);
            Console.WriteLine("default string Value " + s);
        }

        public void FunctionWithoutParameter (int i, out string s, out DateTime d)
        {
            s = string.Empty;
            d = DateTime.MinValue;
        }

        public (int , string, DateTime) ReturnATuple()
        {
            return (100, "Hello", DateTime.Now);
        }

        public void TupleAsInput (int i,(string s1,string s2, string s3))
        {

        }

        public void ClassAsInput (SimpleDataClass sdc)
        {

        }

        public SimpleDataClass ReturnAClass()
        {
            return new SimpleDataClass();
        }
        */

        public void SubmitReview (DateTime reviewDate,string reviewer ,int rating)
        {
            Console.WriteLine("this is Submit review 1");
            double myDouble = 1.5d;

            float myFloat = 1.5f;

            var i = 10;

            var x = 10d;
            decimal d = decimal.Add(1.5m, 2.5m); 


        }
        

        public void SubmitReview2 (DateTime reviewDate, string reviewer="Anonymous", int rating = 0)
        {
           Console.WriteLine("this is Submit review 2");
        }





    }
}