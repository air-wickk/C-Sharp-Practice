using static System.Console;
class VariableUsage
{
    static void Main()
    {

        /* Variable declaration will always be as follows:
         * [variable type] [variable name] = [variable value];
         * It is not always necessary to declare the variable's value on initialization.
         */

        // In this case, we declare an integer named someMoney with a value of 40.
        int someMoney = 40;

        /* Printing strings
         * 
         * To print a string, we use System.Console.WriteLine().
         * However, at the top of the file, we already imported the System.Console library,
         * meaning we do not have to include this part in our print statement.
         * 
         * Within WriteLine()'s parentheses, we include our quotations.
         * Anything within these quotations will be printed to the console.
         * For example: WriteLine("Hello, World!");
         * 
         * Within print statements, we can use {0}, {1}, {2}, etc. within the quotations
         * These act as placeholders for our variables, which are included after.
         * {0} is index 0, and represents the first variable. {1} represents the second, and so on.
         * 
         * Write() can also be used, but it does not create a new line afterwards. Try to create two
         * Write() statements and see how it looks when they print compared to WriteLine().
         * 
         */

        WriteLine("You have ${0}", someMoney);
        WriteLine("You have ${0}. ${0} is how much money you have.", someMoney); // Only need to use variable once as it's {0} both times.

        WriteLine("${0, 5}", someMoney); // the ", 5" within the string format creates a field 5 spaces wide
        WriteLine("{0, -8} dollars", someMoney);

        WriteLine("{0} {1}", "Robert", "Lee"); // "{0} {1}" is the actual formatting for the string, and the string values fill them
        WriteLine("{0,-8}{1,-8}", "Peepee", "Poopoo"); // Negative fields are left aligned, and in this case 8 spaces wide


        // For longer strings, you can concate across lines, so long as you haven't closed the parenthesis
        WriteLine("I have ${0} in my bank account. " +
            "In other words, {0} dollars, which is a lot.", someMoney);


        int lotsofMoney = 2_400_000; // underscore can be added for visual clarity, but do not affect how it displays
        int lotsofMoneys = 2400000;

        WriteLine("Lots of money: {0} and {1}", lotsofMoney, lotsofMoneys); // Note that these two will display the same
    }
}
