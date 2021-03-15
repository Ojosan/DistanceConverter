using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("what would you like to convert between feet, inches, and yards? (example: feet to yards) ");
            string input = Console.ReadLine();

            //booleon

            //feet to yards
            if (input == "feet to yards")
            {
                Console.WriteLine("input number of feet you want to convert to yards");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert+" feet is "+convert/3+" yards.");
            }

            //yards to feet
            else if (input == "yards to feet")
            {
                Console.WriteLine("input number of yards you want to convert to feet");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert + " yards is " + convert * 3 + " feet.");
            }

            //feet to inches
            else if (input == "feet to inches")
            {
                Console.WriteLine("input number of feet you want to convert to inches");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert + " feet is " + convert * 12 + " inches.");
            }

            //inches to feet
            else if (input == "inches to feet")
            {
                Console.WriteLine("input number of inches you want to convert to feet");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert + " inches is " + convert / 12 + " feet.");
            }

            //inches to yards
            else if (input == "inches to yards")
            {
                Console.WriteLine("input number of inches you want to convert to yards");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert + " inches is " + convert / 12 / 3 + " yards.");
            }

            //yards to inches
            else if (input == "yards to inches")
            {
                Console.WriteLine("input number of yards you want to convert to inches");
                double convert = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(convert + " yards is " + convert * 12 * 3 + " yards.");
            }

            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
