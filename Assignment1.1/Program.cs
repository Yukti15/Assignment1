using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Create Your Rectangle");
            Console.WriteLine();
            int length = 0;
            String stringLength = string.Empty; ;
            do
            {
                Console.Write("Enter Length Of Rectangle: ");
                stringLength = Console.ReadLine();
                if (stringLength == "")
                {
                    Console.WriteLine("Please Enter Length..");
                }
            } while (!int.TryParse(stringLength, out length) || (length <= 0 || length > 100));
            int width = 0;
            String stringWidth = string.Empty; ;
            do
            {
                Console.Write("Enter Width Of Rectangle: ");
                stringWidth = Console.ReadLine();
                if (stringWidth == "")
                {
                    Console.WriteLine("Please Enter Length..");
                }
            } while (!int.TryParse(stringWidth, out width) || (width <= 0 || width > 100));
            rectangle.ChangeLength(length);
            rectangle.ChangeWidth(width);
            bool adding = true;
            Program p = new Program();
            while (adding == true)
            {
                int choose = Program.ValidateMenuSelect();
                Console.WriteLine("You Selected Option is : {0}", choose);
                if (choose == 1)
                {
                    int len = rectangle.AddLength();
                    Console.WriteLine("Your Rectangle Length is : {0}", len);
                }
                else if (choose == 2)
                {
                    int length_New = 0;
                    String length_New1 = string.Empty;
                    do
                    {
                        Console.Write("Enter Length Of Rectangle: {0}");
                        length_New1 = Console.ReadLine();
                        if (length_New1 == "")
                        {
                            Console.WriteLine("Please Enter Length..");
                        }
                    } while (!int.TryParse(length_New1, out length_New) || (length_New <= 0 || length_New > 100));
                    rectangle.ChangeLength(length_New);
                    Console.WriteLine("Your Length Of Rectangle is..{0} ", length_New);
                }
                else if (choose == 3)
                {
                    int wide = rectangle.AddWidth();
                    Console.WriteLine("Your Rectangle Length is : {0}", wide);
                }
                else if (choose == 4)
                {
                    int width_New = 0;
                    String width_New1 = string.Empty;
                    do
                    {
                        Console.Write("Enter Width Of Rectangle: ");
                        width_New1 = Console.ReadLine();
                        if (width_New1 == "")
                        {
                            Console.WriteLine("Please Enter Length..");
                        }
                    } while (!int.TryParse(width_New1, out width_New) || (width_New <= 0 || width_New > 100));
                    rectangle.ChangeWidth(width_New);
                    Console.WriteLine("Your Width Of Rectangle is..{0} ", width_New);
                }
                else if (choose == 5)
                {
                    int perimeter = rectangle.Perimeter();
                    Console.WriteLine("Rectangle Perimeter is : {0}", perimeter);
                }
                else if (choose == 6)
                {
                    int area = rectangle.Area();
                    Console.WriteLine("Rectangle Area is : {0}", area);
                }
                else
                {
                    Console.ReadKey();

                }
                Console.WriteLine("Do you want choose functionality Y /N ..? ");
                if (Console.ReadLine() != "Y")
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
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle Length");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 =  Exit\n");
                Console.Write("Please select any option  ");
                userInput = Console.ReadLine();
                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("Invalid Choose");
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
