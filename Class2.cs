using static System.Console;

class UserInput
{
    static void Main()
    {

        // The ReadLine() method is used to read all user input from the keyboard. Example:

        // string myString = ReadLine();

        // To use a type other than string, we must convert using the Convert class or Parse() method.

        const double TAX_RATE = 0.06;
        string itemPriceAsString;
        double itemPrice;
        double totalTax;
        double totalCost;

        // We'll start with the convert class:

        Write("Please enter the price of the item: $");
        itemPriceAsString = ReadLine(); // Taking user input as a string

        // As a shortcut, you can avoid taking the input as a string and convert it on the spot:
        // itemPrice = Convert.ToDouble(ReadLine())

        itemPrice = Convert.ToDouble(itemPriceAsString); // Convert the string input to a double to use in calculations
        totalTax = itemPrice * TAX_RATE;
        totalCost = itemPrice + totalTax;

        WriteLine("With a tax rate of {0}, a(n) {1} item will cost {2} more, for a total of {3}\n", TAX_RATE, itemPrice.ToString("c"),
            totalTax.ToString("c"), totalCost.ToString("c"));


        // Let's look at how we'd do the same with the Parse() method:

        Write("Please enter the price of the item: $");
        itemPrice = double.Parse(ReadLine()); // Convert on the spot to type double

        totalTax = itemPrice * TAX_RATE;
        totalCost = itemPrice + totalTax;

        WriteLine("With a tax rate of {0}, a(n) {1} item will cost {2} more, for a total of {3}\n", TAX_RATE, itemPrice.ToString("c"),
            totalTax.ToString("c"), totalCost.ToString("c"));

        // ---------------------------------------------------------------------------------------------- */

    }
}