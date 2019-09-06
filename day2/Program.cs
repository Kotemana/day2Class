using System;

namespace CoolStoryBro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wanna beer?");

            bool responseWrong = true;

            while (responseWrong)
            {
                string reply = Console.ReadLine();
                switch (reply.ToLower())
                {
                    case "y":
                        Console.WriteLine("Go to Hyena");
                        Console.WriteLine("Friends are always there");
                        responseWrong = false;
                        break;
                    case "n":
                        Console.WriteLine("Visit a doctor");
                        responseWrong = false;
                        break;
                    default:
                        Console.WriteLine("Are you drunk? y or n");
                        break;
                }
            }
            



            Console.ReadLine();
        }
    }
}
