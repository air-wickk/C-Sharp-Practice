using static System.Console;

class Switches
{
    enum Major
    {
        ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING
    }
    static void Main()
    {

        // Switches are a way of doing nested if statements more efficiently
        // For example, look at this code:

        Write("Enter the number of years you've been in school (1-4): ");
        int year = Convert.ToInt32(ReadLine());

        if (year == 1)
            WriteLine("Freshman\n");
        else
            if (year == 2) WriteLine("Sophomore\n");
        else
            if (year == 3) WriteLine("Junior\n");
        else
            if (year == 4) WriteLine("Senior\n");
        else
            WriteLine("Invalid year\n");


        // Clearly, this is a big chunk of code, and readability isn't amazing.
        // Let's look at the same code using the switch structure:

        Write("Enter the number of years you've been in school (1-4): ");
        year = Convert.ToInt32(ReadLine());

        switch (year)
        {
            case 1:
                WriteLine("Freshman\n");
                break; // declares the end of a case
            case 2:
                WriteLine("Sophomore\n");
                break;
            case 3:
                WriteLine("Junior\n");
                break;
            case 4:
                WriteLine("Senior\n");
                break;
            default: // default is used when a test fails every other case
                WriteLine("Invalid year\n");
                break;
        }


        // Multiple cases can share a break:

        Write("Enter the number of years you've been in school (1-4): ");
        year = Convert.ToInt32(ReadLine());

        switch (year)
        {
            case 1:
            case 2:
                WriteLine("Underclass\n");
                break;
            case 3:
            case 4:
                WriteLine("Upperclass\n");
                break;
            default:
                WriteLine("Invalid year\n");
                break;
        }


        /* Switch statements are never required. You can always achieve the
         * same results with if statements. Also, if statements are more flexible.
         * Switch will always check for equivalence, that a = b.
         */

        // Switches are often paired with enumerators. For this example,
        // we will use the enum Major which is found at the top of the file.

        int major;
        string message;

        Write("Enter major code (1-5): ");
        major = Convert.ToInt32(ReadLine());

        switch((Major)major)
        {
            case Major.ACCOUNTING:
            case Major.CIS:
            case Major.MARKETING:
                message = "Major is in the business division\n";
                break;
            case Major.ENGLISH:
            case Major.MATH:
                message = "Major is in the humanities division\n";
                break;
            default:
                message = "Department number is invalid.\n";
                break;
        }

        WriteLine(message);

    }
}