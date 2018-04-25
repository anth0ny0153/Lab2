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
                String userInput;
                //get user input 
                
                Console.WriteLine("Please enter the length of the room");
                userInput = Console.ReadLine();
                length = double.Parse(userInput);

                Console.WriteLine("Please enter the width of the room");
                userInput = Console.ReadLine();
                width = double.Parse(userInput);

                //calculations
                area = length * width;
                perimeter = 2 * (length + width);
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
    }
}
