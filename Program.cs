using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Here is your virtual pet bumblebee!");

            //can now access class VirtualPet

            VirtualPet bumblebee = new VirtualPet(10, 10, 10);

            Console.WriteLine("Please name your bumblebee.");
            bumblebee.Name = Console.ReadLine();

            Console.Clear();

            //creating loop so user can continue to play until they quit

            while (true)
            {
                //bumblebee ascii art
                Console.WriteLine();
                Console.WriteLine(", -.");
                Console.WriteLine(" \\ /");
                Console.WriteLine("{|||)<");
                Console.WriteLine(" / \\ ");
                Console.WriteLine(" `-^");

                    Console.WriteLine(bumblebee.Name + " is a little ornery, please do not swat at him or he will surely sting you!");

                //shows current status of hunger,waste, and boredom
                bumblebee.Status();

                //options for user to choose from to interact with pet
                Console.WriteLine("In order to care for your bumblebee please choose one of the following.");
                Console.WriteLine("1 = Give your bumblebee a flower");
                Console.WriteLine("2 = Swat at your bumblebee");
                Console.WriteLine("3 = Give it some honey");
                Console.WriteLine("4 = Quite Game");

                //depending on the number the user chooses that method will be called into action using switch case or the program will quit
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        bumblebee.Flowers();
                        break;

                    case 2:
                        bumblebee.Swatting();
                        break;

                    case 3:
                        bumblebee.GiveHoney();
                        break;

                    case 4:
                        quit();
                        break;
                }

                //calling tick method updates Flowers and Honey
                bumblebee.Tick();

                //clears current feed and new view will have current status updated
                Console.Clear();

            }


        }

        //quit method ends the program
        static void quit()
        {
            Console.WriteLine("You swatted your bumblebee one too many times and now he is dead.");
            Console.WriteLine("His bumblebee funeral will take place in a few days.");
            Environment.Exit(0);
        }
    }
}


    

