using System;
using System.IO;
using BootcampClassLibrary1;

namespace BootcampConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Class1 Instance = new Class1();
        
        Console.WriteLine("Hello! Welcome to my App!");
        Console.WriteLine("******************************************");
        Console.WriteLine("Press Any key to continue...");
        Console.ReadLine();
        /*
        Class1.DoSomething();

        Class1 Instance = new Class1();
        Instance.DoSomethingElse();

        Instance.AcceptSomeInputs(100, "Hi there");
        Instance.AcceptSomeInputs(10);

        DateTime aDate =Instance.ReturnAValue();

        Instance.ProvideDefaults(99, "Greetings");
        Instance.ProvideDefaults();
        Instance.ProvideDefaults(99);

        string Astring;
        Instance.FunctionWithoutParameter(15, out Astring, out aDate);



        SimpleDataClass myClass = Instance.ReturnAClass();
        myClass.s1 = "That";
        myClass.s2 = "was";
        myClass.s3 = "great";
         
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       
        Instance.SubmitReview(DateTime.Today, "Diwaker", 6);
        Instance.SubmitReview(reviewer:"Falcon",rating:8,reviewDate:DateTime.Today);

        Instance.SubmitReview2(DateTime.Today, rating: 5);
        */

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //STRING CONCEPT
        //StringConcept c2 = new StringConcept();
        //c2.DoSomethingWithString();

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^





        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //ARRAY , LIST , DICTIONARY CONCEPT

        //Array_List al = new Array_List();
        //al.DoSomethongWithList();

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //CLASS and its prperties CONCEPT
        /*
        ClassProp cp = new ClassProp();
        ClassProp cp2 = new ClassProp(15,"Diwaker");
        Console.WriteLine(cp2.Name);
        Console.WriteLine($"The name is {cp2.Name}. The ID is {cp2.ID}");
        */
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^


        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        // PeristaliticPump BoxPump = new Boxer25K("COM1");  
        // BoxPump.RPM = 100;
        // BoxPump.Start();


        // PeristaliticPump Masterpump = new MasterFlexLS("10.10.1.20",2500);
        //Masterpump.RPM = 100;
        //Masterpump.Start();

        // PeristaliticPumpBase makePump = PeristaliticPumpBase.MakePump();
        iperistaliticPump imakePump = PeristaliticPumpFactory.MakePump();


        imakePump.RPM = 100;
        imakePump.Start();
        




        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        Console.WriteLine("Done");
        Console.ReadLine();
    
    
    }
}

