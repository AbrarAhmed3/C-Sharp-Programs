using System;

class PizzaTrent
{
    const double SmallPizzaPrice = 6.99;
    const double LargePizzaPrice = 9.99;
    const double HST = 0.13;
    const double CoverCharge = 0.50;

    static void Main()
    {
        Console.WriteLine("Welcome to PizzaTrent!");

        // Input customer information
        Console.Write("Enter your Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter pizza size ('s' for small, 'l' for large): ");
        char pizzaSize = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Move to the next line after input

        Console.Write("Enter the number of pizzas purchased: ");
        int numberOfPizzas = int.Parse(Console.ReadLine());

        // Validate inputs
        if (numberOfPizzas <= 0)
        {
            Console.WriteLine("Error: At least one pizza needs to be ordered.");
        }
        else if (pizzaSize != 's' && pizzaSize != 'l')
        {
            Console.WriteLine("Error: Invalid pizza size entered.");
        }
        else
        {
            double totalCost;
            if (pizzaSize == 's')
            {
                totalCost = SmallPizzaPrice * numberOfPizzas;
            }
            else
            {
                totalCost = LargePizzaPrice * numberOfPizzas;
            }

            // Add cover charge
            totalCost += CoverCharge;

            // Apply HST if applicable
            if (numberOfPizzas < 12)
            {
                totalCost += totalCost * HST;
            }

            // Output results
            Console.WriteLine($"\nCustomer's Last Name: {lastName}");
            Console.WriteLine($"Number of Pizzas Purchased: {numberOfPizzas}");
            Console.WriteLine($"Total Cost: {totalCost:C}");

            // Signature
            Console.WriteLine("\nProgrammed by: Your First and Last Name");
        }
    }
}
