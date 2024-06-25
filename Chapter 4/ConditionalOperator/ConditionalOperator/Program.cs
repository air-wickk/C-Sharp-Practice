using static System.Console;

class ConditionalOperator
{
    static void Main()
    {

        /* The conditional operator is an abbreviated if-else statement.
         * The syntax is:
         * 
         * testExpression ? trueResult : falseResult;
         * 
         * testExpression is tested to be true or false. If it's true,
         * everything before the colon (trueResult) is executed. If it's
         * false, then vice versa.
         */

        Write("Please enter a number for A: ");
        int a = Convert.ToInt32(ReadLine());
        Write("Please enter a number for B: ");
        int b = Convert.ToInt32(ReadLine());

        // Here, we test if a > b. If it is, biggerNum = a. If it's not, biggerNum = b.
        int biggerNum = (a > b) ? a : b;
        WriteLine(biggerNum + "\n");


        // We can use it to avoid creating variables, in this instance, pass/fail.
        Write("Enter your name: ");
        string name = ReadLine();
        Write("Enter your grade: ");
        double grade = Convert.ToDouble(ReadLine());

        WriteLine($"{name}, your grade is {grade}%. You will {(grade >= 60 ? "pass" : "fail")}.\n");


        // The NOT operator is used as !
        // You are probably familiar with it by now, as != is "not equal"
        // Imagine an R rated movie where you must be 18...

        Write("Enter your age: ");
        int age = Convert.ToInt32(ReadLine());
        bool oldEnough = (age >= 18);

        if (!oldEnough)
            WriteLine("You are underage and cannot see R rated movies.");
        else
            WriteLine("You are over 18 and allowed to see R rated movies.");

    }
}