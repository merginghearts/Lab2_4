using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    class Program
    {
        static void Main(string[] args)
            //1-3
        { int myFirstNumber = 19;
            int mySecondNumber = 244;
            Console.WriteLine(myFirstNumber * mySecondNumber);
            Console.ReadLine();
            //4-6
            string myText = "Some Text";
            Console.WriteLine(myText + " " + mySecondNumber);
            string moreText = "Goes Here";
            Console.WriteLine(myText + " " + moreText);
            Console.ReadLine();

            //7-9
            string color1 = "Yellow";
            string color2 = "Red";
            bool isYellow = true;
            bool isGreen = false;
            Console.WriteLine(color1 + " " + isYellow + " " + color2 + " " + isGreen);
            Console.ReadLine();

            //10-14
            double numbers;
            numbers = mySecondNumber / myFirstNumber;
            Console.WriteLine(numbers);
            Console.ReadLine();
            numbers = mySecondNumber / (double)myFirstNumber;
            Console.WriteLine(numbers);
            Console.ReadLine();

            //15
            Console.WriteLine("Breakpoint Here");

            //16-17
            string textToNumbers = "80743";
            int results = 99 * int.Parse(textToNumbers);
            Console.WriteLine(results);
            Console.ReadLine();

            //18
            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            Console.ReadLine(); 


        }
    }
}
