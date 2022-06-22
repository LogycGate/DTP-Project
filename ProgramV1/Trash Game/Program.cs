using System;
using System.Collections.Generic;

namespace Trash_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string trash = "0";
            int points = 0;

            var canRecycle = new List<string>()
            {
                "Pizza Box",
                "Takeaway Dish",
                "Hard plastic food trays",
                "Tin",
                "Cardboard",
                "Glass bottle",
                "Plastic bottles",
                "Broken glass bottle",
                "Aluminium Can",
            };

            var noRecycle = new List<string>()
            {
                "Battery",
                "Plastic bag filled with recycling",
                "Shoes",
                "Vehicle battery",
                "Wood chippings",
                "Paint can",
                "Brick",
                "Pile of clothes",
                "Hose",
                "Tyre",
                "Polystyrene",
                "Coffee cup",
                "Nappies",
                "Straw", 
                "Gas Bottle",
                "Crockery"
            };

            Random r = new Random();

            Console.WriteLine("Welcome to the recycling game");
            Console.WriteLine("Are you ready? Y/N");
            string ready = Console.ReadLine();

            if (ready == "N")
            {
                Console.WriteLine("Come back when you are ready");
            }
            
            else
            {
                Console.WriteLine("Ok let's begin!");
                while (points < 15)
                {
                    if (r.Next(2) == 1)
                    {
                        trash = canRecycle[r.Next(0, canRecycle.Count)];
                        Console.WriteLine("Can you recycle " + trash + "? Y/N");
                        var answer = Console.ReadLine();
                        if(answer == "Y")
                        {
                            Console.WriteLine("Correct!");
                            points = points + 1;
                            Console.WriteLine("You have " + points + " points!");
                        }

                        else
                        {
                            Console.WriteLine("Wrong");
                            Console.WriteLine("You have " + points + " points!");
                        }
                    }

                    else
                    {
                        trash = noRecycle[r.Next(0, canRecycle.Count)];
                        Console.WriteLine("Can you recycle " + trash + "? Y/N");
                        var answer = Console.ReadLine();
                        if (answer == "N")
                        {
                            Console.WriteLine("Correct!");
                            points = points + 1;
                            Console.WriteLine("You have " + points + " points!");
                        }

                        else
                        {
                            Console.WriteLine("Wrong");
                            Console.WriteLine("You have " + points + " points!");
                        }
                    }
                }
            }
        }
    }
}
