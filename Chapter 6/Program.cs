using System;

namespace Chapter_6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is: " + today.ToLongDateString());

            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine("I will start learning on " + tomorrow.ToShortDateString() +  "." );

            DateTime overloaday = new DateTime(1944, 6, 6);
            Console.WriteLine("D-day of the overlord operation: " + overloaday.ToLongDateString());


           

            //Working with randoness

            //random object generator

            Random randomnumbers = new Random();

            //rollings
            int number1 = randomnumbers.Next(1, 6 + 1);
            int number2 = randomnumbers.Next(1, 6 + 1);
            int number3 = randomnumbers.Next(1, 6 + 1);

            //results
            Console.WriteLine("the results of rolling a dice were: " + number1 + ", " + number2 + ", " + 
                number3 + ".");

            //randoness with 2 dices and throwing 3 times, u just need to create one random generator

            Random newrandomnumbers = new Random();
            int number11 = newrandomnumbers.Next(1,6+1);
            int number12 = newrandomnumbers.Next(1, 6 + 1);

            // path to the desktop

            string pathtodesk = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine("the path to my desktop is: " + pathtodesk);






            Console.ReadLine();


        }
    }
}
