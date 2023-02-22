using System;
using System.IO;

namespace FIleIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello \nwould you like to enter a number?\n(yes or no?)");
            string answer = Console.ReadLine().ToLower();
            while (answer == "yes" || answer == "yeah" || answer == "y")
            {
                try
                {
                    Console.WriteLine("Please type your number");

                    int YourNumber = Convert.ToInt32(Console.ReadLine());

                    using (StreamWriter file = new StreamWriter(@"D:\Users\Demix\Desktop\Basic_C#_Programs\File_IO\File_IO\log\log.txt", true))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " Your number was: " + YourNumber);
                    }
                }

                catch (FormatException x)
                {
                    Console.WriteLine("Please type a whole number", x);
                    return;
                }
                finally
                {
                }
                string text = File.ReadAllText(@"D:\Users\Demix\Desktop\Basic_C#_Programs\File_IO\File_IO\log\log.txt");
                Console.WriteLine("\n" + text);
                Console.ReadLine();
            }
        }
    }


}
