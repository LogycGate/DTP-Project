using System;
using System.Collections.Generic;

namespace Trash_Game { 

    public class Program
    {
        static void Main(string[] args)
        {
            //Clarifying variables.
            string trash = "0";
            int points = 0;
            int health = 3;

            //Establishing lists and sorting trash into recycling and waste.
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
            //Calling the start loop method.
            startMethod();

            //Starting the game.
            Console.WriteLine("Ok let's begin!");
            //The game ends when the user gets 15 points.
            while (points < 15)
            {
                //Picking from the two lists.
                int listNumber = r.Next(canRecycle.Count + noRecycle.Count);
                //Avoiding errors by checking that the list has more than 0 items in the list.
                if (listNumber <= canRecycle.Count)
                {
                    //Pulling an item from the list and assigning it the variable "trash".
                    trash = canRecycle[r.Next(0, canRecycle.Count)];
                    //Removing the selected item from the list to avoid repeats.
                    canRecycle.Remove(trash);
                    Console.WriteLine("Can you recycle " + trash + "? Y/N");
                    var answer = Console.ReadLine();

                    //Checking if the user answer is correct and giving the user a point or subtracting a life accordingly
                    if (answer == "Y")
                    {
                        Console.WriteLine("Correct!");
                        points = points + 1;
                        Console.WriteLine("You have " + points + " points!");
                    }

                    else
                    {
                        Console.WriteLine("Wrong. You lost a life");
                        health = health - 1;
                        Console.WriteLine("You have " + health + " lives left");
                        if (health == 0)
                        {
                            Console.WriteLine("You lose");
                            break;
                        }
                        Console.WriteLine("You have " + points + " points!");
                    }
                }

                else
                {
                    trash = noRecycle[r.Next(0, canRecycle.Count)];
                    noRecycle.Remove(trash);
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
                        Console.WriteLine("Wrong. You lost a life");
                        health = health - 1;
                        Console.WriteLine("You have " + health + " lives left");
                        if (health == 0)
                        {
                            Console.WriteLine("You lose");
                            break;
                        }
                        Console.WriteLine("You have " + points + " points!");
                    }
                }
            }   
        }
        static void startMethod()
        {
            while (true)
                {
                Console.WriteLine("Welcome to the recycling game");
                Console.WriteLine("Are you ready? Y/N");
                string ready = Console.ReadLine();

                if (ready == "N")
                {
                    Console.WriteLine("Come back when you are ready");
                }

                else if (ready == "Y")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please input a valid answer!");
                    Console.WriteLine("Note: Case Sensitive");
                }
            }
        }
    }
}

