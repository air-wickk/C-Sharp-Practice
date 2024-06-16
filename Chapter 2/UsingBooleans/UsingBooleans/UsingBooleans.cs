using static System.Console;

class IntroToBooleans
{
    static void Main()
    {
        // Booleans are true/false statements
        bool areYouDead = false;
        bool areYouTired = true;

        /* Booleans are most commonly used to make comparisons using the following:
         * < (Less than)
         * > (Greater than)
         * == (Equal to)
         * <= (Less than or equal to)
         * >= (Greater than or equal to)
         * != (Not equal to)
         */

        double hoursWorked = 40.3;
        bool doesReceiveOvertime = hoursWorked > 40;
        WriteLine("Has worked enough to receive overtime? {0}", doesReceiveOvertime);

    }
}