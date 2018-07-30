using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
        int yourAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Please answer True or False.");
        bool hadDUI = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        int speedTix = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Are you qualified for our insurance?");
        bool amiQualifiedage = (yourAge <= 15);
        bool tixQualified = (speedTix >= 3);
        Console.WriteLine("Based on what you've entered, your qualifications are {0}", amiQualifiedage==tixQualified!=hadDUI);
        Console.ReadLine();
        }
    }

