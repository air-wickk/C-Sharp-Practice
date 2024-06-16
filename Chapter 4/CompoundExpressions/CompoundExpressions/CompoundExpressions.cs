using static System.Console;

class CompoundExpressions
{
    static void Main()
    {

        /* && is the symbol for AND in programming. Essentially, this means
         * that both X and Y must be true for the overall statement to be true.
         * If one or the other is false, or both are false, the statement is false.
         * We can use && to condense our logic into fewer lines.
         */

        // Notice that these have the same function. Program using &&:

        Write("Enter a valid age: ");
        int age = Convert.ToInt32(ReadLine());

        if (age >= 0 && age <= 120)
            WriteLine("Age is valid\n");

        // Program using nested if statements:

        Write("Enter a valid age: ");
        age = Convert.ToInt32(ReadLine());

        if (age >= 0)
            if (age <= 120)
                WriteLine("Age is valid\n");


        /* Understand that the && statement looks for two complete statements.
         * The following program will not compile:
         * 
         * int bonus;
         * int saleAmount = 3000;
         * 
         * if(saleAmount > 1000 && < 5000)
         *    bonus = 400;
         *    
         * This is because the right side of the expression is incomplete.
         * Read it in your head as "if saleAmount is greater than 1000 and
         * [blank] is less than 5000. 
         * 
         * Notice the problem? There is nothing to compare 5000 to.
         * The correct statement is as follows:
         */

        int bonus;
        int saleAmount = 3000;

        if (saleAmount > 1000 && saleAmount < 5000)
            bonus = 400;

        // For clarity, you can also include parentheses if you prefer.

        if ((saleAmount > 1000) && (saleAmount < 5000))
            bonus = 400;


        /* || is the symbol used for OR in programming. This means that,
         * if any condition in the expression is true, then the total
         * statement is true. The only time it is false is when both X
         * and Y are evaluated to be false.
         */

        // Again, notice that these have the same function. Program using ||:

        Write("Enter an invalid age: ");
        age = Convert.ToInt32(ReadLine());

        if ((age < 0) || (age > 120))
            WriteLine("Age is invalid\n");

        // Program using nested if statements:

        Write("Enter an invalid age: ");
        age = Convert.ToInt32(ReadLine());

        if (age < 0)
            WriteLine("Age is invalid\n");
        else if (age > 120)
            WriteLine("Age is invalid\n");


        /* Those were the conditional variants of AND (&&) and OR (||).
         * But, there are also logical versions.
         * 
         * AND (&) and OR (|) are used to always evaluate both sides.
         * Because they are not making comparisons, they don't care
         * about whether or not the statement is true or false, they
         * execute anyways. For example:
         */

        int salesAmountForYear = 9000;
        int yearsOfService = 7;

        // This statement only wants to know if both are true.
        // Meaning that, if the first statement is false, it ignores the second.

        if ((salesAmountForYear >= 10000) && (++yearsOfService > 10))
            bonus = 200;

        /* On the other hand, this statement, despite failing the first part,
         * Will continue to increment yearsOfService because of (&).
         * 
         * Think of this as "if salesAmountForYear >= 10000,
         * then set bonus to 200. Additionally, increment yearsOfService
         * whether its value is > 10 or not.
         */

        if ((salesAmountForYear >= 10000) & (++yearsOfService > 10))
            bonus = 200;


        // You can combine any combination of && and || operators as you need.
        // Let's use that fact to determine eligibility for a discount on G rated movies.

        char rating;
        int movieAge;

        Write("Enter your age for the movie: ");
        movieAge = Convert.ToInt32(ReadLine());

        Write("Enter the rating (case sensitive): ");
        rating = Convert.ToChar(ReadLine());

        // Pay close attention to the parentheses. If we did not group the || statement
        // together, it would allow someone <12 to see an R rated movie.

        if ((movieAge <= 12 || movieAge >= 65) && (rating == 'G'))
            WriteLine("Discount applies.\n");
        else
            WriteLine("Discount does not apply.\n");


        // Let's remove the parentheses, and run using the age '10' and rating 'R':

        Write("Enter your age for the movie: ");
        movieAge = Convert.ToInt32(ReadLine());

        Write("Enter the rating (case sensitive): ");
        rating = Convert.ToChar(ReadLine());

        if (movieAge <= 12 || movieAge >= 65 && rating == 'G')
            WriteLine("Discount applies.\n");
        else
            WriteLine("Discount does not apply.\n");



















    }
}