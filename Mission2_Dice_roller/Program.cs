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
        
        // Create class of attempts of rolls
        int[] rollResults = DiceRoller.twoDieRoll(rollsNum);
        
        // Intro message on how results are displayed
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n   Each \"*\" represents 1% of the total number of rolls.\n   Total number of rolls = " + rollsNum);
        
        // Create int array with number of times a certain sum came in the die rolls
        int[] counts = new int[13];
        foreach (int result in rollResults)
        {
            counts[result]++;
        }

        // Print histogram and calculate percentage based on number of times a sum occured from counts array
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (counts[i] * 100) / rollsNum;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
        
        // End message
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }
}