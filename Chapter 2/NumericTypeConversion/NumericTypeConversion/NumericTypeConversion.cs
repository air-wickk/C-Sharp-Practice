using static System.Console;

class NumericTypeConversion
{
    static void Main()
    {
        // Multiplying an integer with a double makes the result inherently a double
        int hoursWorked = 36;
        double payRate = 12.35;
        double grossPay = hoursWorked * payRate;

        // Note that for the method below, we could also use "F2" in the ToString conversion to convert to 2 floating decimals
        WriteLine("Working {0} hours at a pay rate of ${1} makes your gross pay " + grossPay.ToString("C"), hoursWorked, payRate); // Output double


        /* If we try to assign the result to an integer, for example:
         * int grossPay = hoursWorked * payRate
         * We will receive an error as we did not cast the result from double to integer.
         */

        // To cast, we do the following:
        grossPay = (int)(hoursWorked * payRate);

        WriteLine("Working {0} hours at a pay rate of ${1} means your gross pay is ${2}", hoursWorked, payRate, grossPay); // Output int
        WriteLine();


        /*
         * A more complex casting example using finances
         */

        double spendingMoney = 191.66;
        float weeklyBudget = (float) spendingMoney / 4; // Weekly budget is 191.66/4 = 47.915
        int dollars = (int) weeklyBudget; // Dollars is 47, as the decimals are cut off

        WriteLine("Your spending money is ${0}. You can spend " + weeklyBudget.ToString("c") + " weekly, or in other words, ${1}", spendingMoney, dollars);






        

    }
}