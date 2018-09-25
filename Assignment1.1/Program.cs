using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
          

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            int length = 0;
            String stringLength = string.Empty; ;
            do
            {
                Console.Write("********************** Assignment#1 Unit Testing ********************** \n\n");
                Console.Write("Please provide details for Rectangle below- \n");
                Console.Write("Please Enter Length: ");
                stringLength = Console.ReadLine();
                if (stringLength == null)
                {
                    Console.WriteLine("Please enter data...");
                }
               
            } while (!int.TryParse(stringLength, out length) || (length <= 0 || length > 100));
            int width = 0;
            String stringWidth = string.Empty; ;
            do
            {
                Console.Write("Please Enter Width: ");
                stringWidth = Console.ReadLine();
                if (stringWidth == null)
                {
                    Console.WriteLine("Please enter data...");
                }
            } while (!int.TryParse(stringWidth, out width) || (width <= 0 || width > 100));
            rectangle.SetLength(length);
            rectangle.SetWidth(width);
            bool adding = true;
            Program p = new Program();
            while (adding == true)
            {
                int choose = Program.ValidateMenuSelect();
                Console.WriteLine("You selected: {0}\n", choose);
                if (choose == 1)
                {
                    int lnt = rectangle.GetLength();
                    Console.WriteLine("Rectangle length is: {0}\n", lnt);
                }
                else if (choose == 2)
                {
                    int length_New = 0;
                    String length_New1 = string.Empty;
                    do
                    {
                        Console.Write("Please Enter Length: ");
                        length_New1 = Console.ReadLine();
                        if (length_New1 == null)
                        {
                            Console.WriteLine("Please enter data...");
                        }

                    } while (!int.TryParse(length_New1, out length_New));
                     rectangle.SetLength(length_New);
                    Console.WriteLine("Rectangle length is: {0}\n", length_New);
                }
               
                else if (choose == 3)
                {
                    int widt = rectangle.GetWidth();
                    Console.WriteLine("Rectangle width is: {0}\n", widt);
                }
                else if (choose == 4)
                {
                    int width_New = 0;
                    String width_New1 = string.Empty;
                    do
                    {
                        Console.Write("Enter Width Of Rectangle: ");
                        width_New1 = Console.ReadLine();
                        if (width_New1 == null)
                        {
                            Console.WriteLine("Please Enter Length..");
                        }
                    } while (!int.TryParse(width_New1, out width_New) || (width_New <= 0 || width_New > 100));
                    rectangle.SetWidth(width_New);
                    Console.WriteLine("Rectangle width is: {0}", width_New);
                }
                else if (choose == 5)
                {
                    int Getperimeter = rectangle.Getperimeter();
                    Console.WriteLine("Rectangle Perimeter is: {0}\n", Getperimeter);
                }
                else if (choose == 6)
                {
                    int Getarea = rectangle.Getarea();
                    Console.WriteLine("Rectangle Area is: {0}\n", Getarea);
                }
                else if (choose==7)
                {
                    Console.WriteLine("The Application is now closing... Press any key to EXIT");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else 
                {
                    Console.ReadKey();

                }
                Console.WriteLine("Would you like to continue? ");
                if (Console.ReadLine() != "Yes")
                {
                    adding = false;
                }
            }
            Console.ReadKey();
        }

        public static int ValidateMenuSelect()
        {
            string userInput = "";
            bool validMenuSelect = false;
            while (validMenuSelect == false)
            {
                Console.WriteLine("************************************");
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 =  Exit\n");
                Console.WriteLine("************************************");
                Console.Write("Please select an option ");
                userInput = Console.ReadLine();
                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("Invalid input! Please Try Again");
                }
                else
                {
                    validMenuSelect = true;
                }

            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
    }
}
