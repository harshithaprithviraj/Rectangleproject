using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program

    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }

            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out aNumber);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                }
                else if(aNumber < 0)
                {
                    Console.WriteLine("Number cannot be less than O, please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"Your rectangle {rectSide} is now: {aNumber}.\n");
                }
            }

            return aNumber;
        }


        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            bool validRectSelect = false;
            string rectSelection;
            int selection;
           

            while (validRectSelect == false)
            {
                Console.WriteLine("1 = Create a default rectangle (1 * 1).\n");
                Console.WriteLine("2 = Create a custom rectangle.\n");
                Console.WriteLine("Choose a menu item to begin:");
                rectSelection = Console.ReadLine();
                Console.WriteLine();

                if (rectSelection != "1" && rectSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(rectSelection) == 1)
                {
                    validRectSelect = true;
                    Random random = new Random();
                    int length;
                    int width;

                    length = 1;
                    width = 1;
                    

                    Console.WriteLine($"Your default rectangle length and width is {length} and {width}.\n");
                    Rectangle customRect = new Rectangle(length, width);
                     r = customRect;

                }

                else if (int.Parse(rectSelection) == 2)
                {
                    validRectSelect = true;

                    int length;
                    int width;

                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");

                    Console.WriteLine($"Your custom numbers are {length} and {width}.\n");
                    Rectangle customRect = new Rectangle(length, width);
                    r = customRect;
                }
            }
            selection = ValidateMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length is: {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of rectangle is: {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of rectangle is: {r.GetArea()}\n");
                        break;
                    default:
                        break;
                }

                selection = ValidateMenuSelection();

            }

        }
    }
}