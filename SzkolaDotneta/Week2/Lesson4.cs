using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaDotneta.Week2
{
    static class Lesson4
    {
        static public void MainProgram()
        {
            bool exit = false;
            string mainMenu = "Please select which exercise you want to turn on:\n" +
                                "1. Excercise no. 1\n" +
                                "2. Excercise no. 2\n" +
                                "3. Excercise no. 3\n" +
                                "4. Excercise no. 4\n" +
                                "5. Excercise no. 5\n" +
                                "6. Exit\n\n" +
                                "Selection: ";

            do
            {
                Console.Clear();
                Console.Write(mainMenu);
                if (int.TryParse(Console.ReadLine().Trim(), out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            PointOne();
                            break;
                        case 2:
                            PointTwo();
                            break;
                        case 3:
                            PointThree();
                            break;
                        case 4:
                            PointFour();
                            break;
                        case 5:
                            PointFive();
                            break;
                        case 6:
                            exit = true;
                            break;
                    }

                }

            } while (!exit);
        }

        static private void PointOne()
        {
            String name;
            String surname;
            int age;
            char sex;
            string pesel;
            string employeeNo;
        }

        static private void PointTwo()
        {
            char firstLetter = 'a';
            char secondLetter = 'b';
            char thirdLetter = 'c';

            Console.WriteLine($"Third letter: {thirdLetter}, second letter: {secondLetter} and first letter: {firstLetter}");
        }

        static private void PointThree()
        {

            Console.WriteLine("Please input length of rectangle: ");
            double.TryParse(Console.ReadLine(), out double length);

            Console.WriteLine("Please input width of rectangle: ");
            double.TryParse(Console.ReadLine(), out double width);

            if (length == 0 || width == 0)
            {
                Console.WriteLine("Some data wasn't correct.");
            }
            else
            {
                Console.WriteLine($"Diagonal of this rectangle is: " + Math.Sqrt((Math.Pow(length, 2) + Math.Pow(width, 2))));
            }


            Console.WriteLine("Returning to main menu, please press any key to continue.");
            Console.ReadKey();
            Console.Clear();

        }

        static private void PointFour()
        {
            int firstInt = 10;
            double secondInt = 12.5;
            string text = "Szkoła Dotneta";
        }

        static private void PointFive()
        {
            bool error = false;

            Console.WriteLine("Please input your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please input lastname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Please input your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                error = true;
            }

            Console.WriteLine("Please input weight: ");
            if (!double.TryParse(Console.ReadLine(), out double weight))
            {
                error = true;
            }

            Console.WriteLine("Please input phone number: ");
            string phoneNo = Console.ReadLine();

            Console.WriteLine("Please input your e-mail address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please input your sex (M/F): ");
            if (!char.TryParse(Console.ReadLine().ToUpper(), out char sex) || !(sex == 'M' || sex == 'F'))
            {
                error = true;
            }

            if (error)
            {
                Console.WriteLine("Some data wasn't correct.");
            }

            Console.WriteLine("Returning to main menu, please press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
