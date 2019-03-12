using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_pin_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Hey there! This is your first time using this program, So I'm going to need you to enter a 4 numbered pin: ");
            int pin1 = int.Parse(Console.ReadLine());

            if (pin1 > 1000 && pin1 < 9999)
            {
                Console.WriteLine("Please Re-enter the pin your just created (if you remember lmao): ");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin1 == pin2)
                    Console.WriteLine("Pin has been accepted");
                else
                    Console.WriteLine("The pin entered has been rejected. A.K.A it's W R O N G");

            }
            else
                Console.WriteLine("Your pin is either less then 4 numbers or more, and if it is. You have terrible reading since I specifically said 4 NUMBERS.");




            Console.WriteLine("Nice. Press enter to continue...");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
