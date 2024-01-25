using Dice;

class RollingDice
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] rollResult = roller.RollDice(numberOfRolls); // roller(instance name).method name from DiceRoller > using method(funciont) of the "DiceRoller" class

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"{i}: ");
            int percentage = (int)((rollResult[i] / (double)numberOfRolls) * 100);
            Console.WriteLine(new String('*', percentage));
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}