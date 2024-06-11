using static System.Console;
class GreenVilleMotto2
{
    static void Main()
    {
        // Variable declaration
        int someMoney = 40;

        // String formatting
        WriteLine("You have ${0}", someMoney);
        WriteLine("You have ${0}. ${0} is how much money you have.", someMoney); // Only need to use variable once as it's {0} both times.
        WriteLine("${0, 5}", someMoney); // the ", 5" within the string format creates a field 5 spaces wide
        WriteLine("{0, -8} dollars", someMoney);

        WriteLine("{0} {1}", "Robert", "Lee"); // "{0} {1]" is the actual formatting for the string, and values fill them
        WriteLine("{0,-8}{1,-8}", "Penis", "Balls"); // Negative fields are left aligned, and in this case 8 spaces wide

        // For longer strings, you can concate across lines
        WriteLine("I have ${0} in my bank account. " +
            "In other words, {0} dollars, which is a lot.", someMoney);

        int lotsofMoney = 2_400_000;
        int lotsofMoneys = 2400000;

        WriteLine("Lots of money: {0} and {1}", lotsofMoney, lotsofMoneys);
    }
}
