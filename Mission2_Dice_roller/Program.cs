// See https://aka.ms/new-console-template for more information
/*
 * Write a .NET console application using C# that simulates the rolling of two 6-sided dice (NOTE:
   NOT a one 12-sided die.) Use an array to keep track of the number of times that each
   combination is thrown. In other words, keep track of how many times the combination of the two
   simulated dice is 2, how many times the combination is 3, and so on, all the way up through 12.
   
   Allow the user to choose how many times the “dice” will be thrown. 
   
   Then, once you have that number of rolls, pass that number to a second class that has a method that simulates the roll of
   the dice for the number of times that the user specified. Store the results in an array. The method
   in the second class should return that array containing the roll results to the first class. In the first
   class, use that array to print a histogram (using the * character) that shows the total percentage
   each number was rolled. Each * will represent 1% of the total rolls.
   
   Sample session:
   Welcome to the dice throwing simulator!
   How many dice rolls would you like to simulate? 1000
   DICE ROLLING SIMULATION RESULTS
   Each "*" represents 1% of the total number of rolls.
   Total number of rolls = 1000.
   2: ***
   3: ***
   4: ***********
   5: ***********
   6: ********
   7: ******************
   8: ****************
   9: **********
   10: *************
   11: *****
   12: **
   Thank you for using the dice throwing simulator. Goodbye!
   NOTE: Due to rounding issues and the fact that you ca
 */

using Mission2_Dice_roller;

internal class Program
{
    public static void Main(string[] args)
    {
        int rollsNum = 0;
        
        // Ask user for input for number of simulated dice rolls
        Console.WriteLine("Welcome to the dice simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        
        // Store user input for desired rolls
        int.TryParse(Console.ReadLine(), out rollsNum);
        
        // for the number of times user said
             // roll die 1 and collect result
             // roll die 2 and collect
             // add result
             
        // for each number of possible to be rolled
            // print number (2, 3, 4, 5, ...)
            // callculate perecentage of times it was rolled
            // pringt an asterisk fo each percent it was rolled (loop but also method exists)
        DiceRoller.twoDieRoll(rollsNum);


    }
}