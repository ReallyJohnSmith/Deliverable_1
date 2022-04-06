using System;
					
public class Program
{
	public static void Main()
	{
		bool restart;
            do
            {
                // What kind of sandwiches are being made
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int personCount = Convert.ToInt32(Console.ReadLine());
                // calculate the total amount of slices of bread
                int breadPerSammy = 2;
                int slicesPerLoaf = 28;
                double totalSlicesNeeded = breadPerSammy * personCount;
                var totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);
                // calculate the total amount of PB tablespoons
                int tablespoonsPBPerSammy = 2;
                int tablespoonsPBPerJar = 32;
                double totalTbspPBNeeded = tablespoonsPBPerSammy * personCount;
                var totalPBJarsNeeded = Math.Ceiling(totalTbspPBNeeded / tablespoonsPBPerJar);
                // calculate the total amount of Jelly teaspoons
                int teaspoonsJellyPerSammy = 4;
                int teaspoonsJellyPerJar = 48;
                double totalTspJellyNeeded = teaspoonsJellyPerSammy * personCount;
                var totalJellyJarsNeeded = Math.Ceiling(totalTspJellyNeeded / teaspoonsJellyPerJar);
                //Final Display
                Console.WriteLine("\n");
                Console.WriteLine("You need:");
                Console.WriteLine("\n");
                Console.WriteLine("{0} slices of bread", totalSlicesNeeded);
                Console.WriteLine("{0} tablespoons of peanut butter", totalTbspPBNeeded);
                Console.WriteLine("{0} teaspoons of jelly", totalTspJellyNeeded);
                Console.WriteLine("\n");
                Console.WriteLine("Which is...");
                Console.WriteLine("\n");
                Console.WriteLine("{0} loaves of bread", totalLoavesNeeded);
                Console.WriteLine("{0} jars of peanut butter", totalPBJarsNeeded);
                Console.WriteLine("{0} jars of jelly", totalJellyJarsNeeded);
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                var userInput = Console.ReadLine().ToUpper();
                if (userInput == "Y" || userInput == "YES")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }
            } while (restart);
            Console.WriteLine("\n");
            Console.WriteLine("Goodbye!");
	}
}