using System;

namespace Studio_1
{
    class Circle

    {
        static void Main(string[] args)

        {
            string input;
            string mpgInput;
            double radius;
            double area;
            double circumfrence;
            double diameter;
            double mpg;
            double distance;


            Console.WriteLine("Area of circle:");
            input = Console.ReadLine();
            radius = float.Parse(input);

            area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The area of a circle with radius " + radius + " is " + area);

            circumfrence = radius * 2 * Math.PI;
            diameter = radius * 2;
            Console.WriteLine("The Circumfrence of a circle with radius " + radius + " is " + circumfrence + " and the diameter is " + diameter);

            Console.WriteLine("How many miles can your car go on one gallon of gas?");
            mpgInput = Console.ReadLine();
            mpg = float.Parse(mpgInput);

            distance = mpg / circumfrence;

            Console.WriteLine("Your car will travel around the circle " + distance + "times.");

            //finished required sections


        }
    }
}
