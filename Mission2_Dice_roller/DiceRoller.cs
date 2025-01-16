namespace Mission2_Dice_roller;

public class DiceRoller()
{
        // Pass back array of the results to print in main
        // Method to do the die simulation
        
        // for the number of times user said
        // roll die 1 and collect result
        // roll die 2 and collect
        // add result
        public static int[] twoDieRoll(int numOfRolls)
        {
                // Declare variables needed for dice rolls
                int[] rollSums = new int[numOfRolls];
                Random rnd = new Random();
                int dice1 = 0;
                int dice2 = 0;

                for (int i = 0; i < numOfRolls; i++)
                {
                        dice1 = rnd.Next(1, 7);
                        dice2 = rnd.Next(1, 7);

                        rollSums[i] = (dice1 + dice2);
                }
                
                return rollSums;
        }
}