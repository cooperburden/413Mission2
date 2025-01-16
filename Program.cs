// See https://aka.ms/new-console-template for more information


using System;

namespace Mission2;

class Program
{
   static void Main(string[] args)
   {
       Console.WriteLine("Welcome to the Dice Rolling Simulator!"); // Welcome the user
      
       Console.WriteLine("How many times would you like to roll the dice? "); // Prompt the user to enter number of rolls
       
       string NumOfRolls = Console.ReadLine(); // Read whatever the user inputed and assign it to the variable of NumOfRolls
       
       int numOfRolls = int.Parse(NumOfRolls); // Change NumOfRolls to an integer, so the program can use it.
       
       DiceRoller roller = new DiceRoller(); // Create an instance of the DiceRoller class
       int[] rollCounts = roller.RollDice(numOfRolls); // Get the dice roll counts from the DiceRoller class
       
       for (int i = 0; i < rollCounts.Length; i++)  // Creating a loop that will calculate the percentage each number is rolled,
                                                    // print each number and the correct number of stars

       {
           double percentage = (double)rollCounts[i] / numOfRolls * 100; // Calculate the percentage of times the sum was rolled. 
                                                                        // double makes it a percentage 
          
           Console.Write($"{i + 2}: "); // Dynamically print each number, before the : sign
           int stars = (int)percentage; // We want the number of stars to be an integer
           for (int j = 0; j < stars; j++)
           {
               Console.Write("*");
           }
           Console.WriteLine();  // Move to the next line after printing the stars
       }

       Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye");
   }
}





