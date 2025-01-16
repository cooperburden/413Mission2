namespace Mission2;

public class DiceRoller
{
    
        public int[] RollDice(int numOfRolls)
        {
            Random rand = new Random(); // Creating an instance of the Random class, called rand 
            int[] rollCounts = new int[11]; // Array to hold the count of rolls for each sum (2-12)
       
            for (int i = 0; i < numOfRolls; i++)  // Loop through the number of rolls
            {
                int die1 = rand.Next(1, 7);    // Random number for die 1 (between 1 and 6)
                int die2 = rand.Next(1, 7);    // Random number for die 2 (between 1 and 6)
           
                int sum = die1 + die2;        // The sum of the two dice
           
                rollCounts[sum - 2]++;        // subtracting 2 from the sum, because that is the compartment of the array that will be counted
                // ++ is to add 1 to that compartment, because we are just counting how many times each number is rolled
            }


            return rollCounts; // Return the array of roll counts
        }
    

}