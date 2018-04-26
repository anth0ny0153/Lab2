using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            //declare  variables
                double length = 0;
                double width = 0;
                double area = 0;
                double perimeter = 0;
                        //String userInput;
                        //get user input 
                length = ReadDoubles("Please enter the length of the room");
                        //Console.WriteLine("Please enter the length of the room");
                        //userInput = Console.ReadLine();
                        //length = double.Parse(userInput);
                width = ReadDoubles("Please enter the width of the room");
                        //Console.WriteLine("Please enter the width of the room");
                        //userInput = Console.ReadLine();
                        //width = double.Parse(userInput);

                //calculations
                area = CalcArea(length, width);
                        //area = length * width;
                perimeter = CalcPerimeter(length, width);
                        //perimeter = 2 * (length + width);

                Console.WriteLine("The area of the room is: " + area);

                Console.WriteLine("The perimeter of the room is: " + perimeter);
                        //Console.WriteLine($"The perimeter of the room is: {perimeter} ");
                        //a different way to do it ^


                //rerun program
                Console.WriteLine("Do you want to run the program again? (yes/no)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;
                
            }
        }
        public static double ReadDoubles(string message)
        {
            Console.WriteLine(message);
            double input = double.Parse(Console.ReadLine());
            return input;
        }
        public static double CalcArea(double length, double width)
        {
            double area;
            area = length * width;

            return area;
        }
        public static double CalcPerimeter(double length, double width)
        {
            double perimeter;
            perimeter = 2 * (length + width);

            return perimeter;
        }
    }
}
