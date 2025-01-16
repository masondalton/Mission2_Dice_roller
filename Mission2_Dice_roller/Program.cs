/*
 * Mason Dalton
 * Section 2
 * Group 6
 * Hilton - 413
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