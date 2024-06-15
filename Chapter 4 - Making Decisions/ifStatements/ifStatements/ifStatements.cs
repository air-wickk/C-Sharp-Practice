using static System.Console;

class ifStatements
{
    static void Main()
    {

        /* 
         * If statements are used to evaluate any true/false statement,
         * and make decisions based on the result. It takes on this form:
         * 
         * if(testedexpression)
         *    statement;
         *    
         * Where testedExpression is the t/f condition, and statement is
         * what is executed depending on that outcome. t/f = booleans.
        */


        /* 
         * In the following program, the user is prompted to enter a number,
         * and a second number to compare with the first.
         * 
         * The first if statement checks to see if the first number is greater
         * than the second. If it isn't, it moves on to "else if", because the first
         * condition was false. If the "else if" is false, there is only one condition that
         * can be true. If it is neither greater nor lesser than, they must be equal.
         */
        
        Write("Enter a number: ");
        int number = Convert.ToInt32(ReadLine());
        Write("Enter a number to compare it to: ");
        int compareNumber = Convert.ToInt32(ReadLine());

        if (number > compareNumber)
            WriteLine("{0} is greater than {1}.\n", number, compareNumber);
        else if (number < compareNumber)
            WriteLine("{0} is less than {1}.\n", number, compareNumber);
        else
            WriteLine("{0} is equal to {1}.\n", number, compareNumber);


        // If we want to execute two or more statements, we will need a "block" using { }
        // However, you can still put only one statement in a block. It is up to you.

        Write("Enter the letter A or B (case sensitive): ");
        char letter = Convert.ToChar(ReadLine());
        
        if (letter == 'A')
        {
            WriteLine("B");
            WriteLine("C\n");
        }
        else if (letter == 'B')
        {
            WriteLine("C\n"); // Notice only one statement here
        }


        // You can also "nest" other if statements within an if statement:
        // This can get pretty complex, so read it step-by-step to follow the logic.

        const int LOW = 1;
        const int HIGH = 10;

        Write("Enter a number between 1-10: ");
        int numChoice = Convert.ToInt32(ReadLine());

        if(numChoice > LOW)
        {
            if(numChoice < HIGH)
            {
                WriteLine("{0} is less than {1} but greater than {2}\n", numChoice, HIGH, LOW);
            } 
            else if (numChoice == HIGH) // Note we need == not =
            {
                WriteLine("{0} is greater than {1} but equal to {2}\n", numChoice, LOW, HIGH);
            }
            else
            {
                WriteLine("{0} isn't between 1-10. Follow instructions, dipshit.\n", numChoice);
            }
        }
        else if (numChoice == LOW) // Note we need == not =
        {
            WriteLine("{0} is less than {1} but equal to {2}\n", numChoice, HIGH, LOW);
        }
        else
        {
            WriteLine("{0} isn't between 1-10. Follow instructions, dipshit.\n", numChoice);
        }

    }
}