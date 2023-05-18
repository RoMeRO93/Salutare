using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        var currentCulture = Thread.CurrentThread.CurrentCulture;

        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-us");
            string shortDateString = DateTime.Now.ToShortDateString();
            // Do something with shortDateString...
            if (DateTime.Now.Day <= 10)
            {
                Console.WriteLine("Buna dimineata!");
            }
            else if (DateTime.Now.Day <= 20)
            {
                Console.WriteLine("Buna ziua!");
            }
            else
            {
                Console.WriteLine("Buna seara!");
            }
        }
        finally
        {
            Thread.CurrentThread.CurrentCulture = currentCulture;
        }
    }
}
