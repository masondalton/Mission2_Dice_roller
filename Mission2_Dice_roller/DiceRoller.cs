namespace Mission2_Dice_roller;

public class DiceRoller()
{
        public static int[] twoDieRoll(int numOfRolls)
        {
                // Declare variables needed for dice rolls
                int[] rollSums = new int[numOfRolls];
                Random rnd = new Random();
                int dice1 = 0;
                int dice2 = 0;

                // For loop to roll die for how many attempt user requested
                for (int i = 0; i < numOfRolls; i++)
                {
                        dice1 = rnd.Next(1, 7);
                        dice2 = rnd.Next(1, 7);
                        
                        // Adds sum of both die to array 
                        rollSums[i] = (dice1 + dice2);
                }
                
                // Returns sum array for creating histogram
                return rollSums;
        }
}