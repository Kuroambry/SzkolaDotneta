using System;

namespace SzkolaDotneta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string mainMenu = "Choose which lesson you want to open:\n" +
                                "1. Week 2 Lesson 4\n" +
                                "9. Exit\n" +
                                "Select: ";
            do
            {
                Console.Clear();
                Console.Write(mainMenu);
                if (int.TryParse(Console.ReadLine().Trim(), out int selection))
                {
                    switch (selection)
                    {
                        case 1:
                            Week2.Lesson4.MainProgram();
                            break;
                        case 9:
                            exit = true;
                            break;
                    }

                }

            } while (!exit);
        }
    }
}
