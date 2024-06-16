using static System.Console;

class ArithmeticOperators
{
    static void Main()
    {

        /*
         * Arithmetic 
        */

        int result = 3 + 4 * 2; // Will follow PEMDAS
        WriteLine("The result is: {0}", result);

        int hours = 40;
        int rate = 22;
        int bonus = 200;

        int weeklypay = (hours * rate) + bonus;
        WriteLine("The total weekly pay is " + weeklypay.ToString("c"));
        WriteLine();


        /*
         * Add and assign operator
        */

        // The two following operations have the exact same meaning
        int counter = 0;
        counter = counter + 1; // Add 1 (output = 1)
        counter += counter; // Add 1 (output = 2)
        WriteLine("Current counter value is {0}", counter);

        // More complex operations can be used too
        double bankBal = 3000;
        double interestRate = 0.02;

        bankBal += bankBal * interestRate; // This is essentially bankBal = bankBal + bankBal * interestRate
        WriteLine("Your current bank balance is: " + bankBal.ToString("c"));
        WriteLine();


        /*
         * Additional shortcut operators
        */

        double balanceDue = 100;
        double paymentMade = 50;
        balanceDue -= paymentMade; // Will subtract paymentMade from balanceDue and update it with its new value
        WriteLine("Balance still due after payment is " + balanceDue.ToString("c"));


        double exampleRate = 0.04;
        exampleRate *= 100; // Will multiply exampleRate by 100 and update it with its new value
        WriteLine("Your interest rate is {0}%", exampleRate);

        double examplePayment = 75;
        examplePayment /= 12; // Will divide examplePayment by 12 and update it with its new value
        WriteLine("Your monthly payment is " + examplePayment.ToString("c"));
        WriteLine();


        /*
         * Increments & Decrements
        */

        int someValue = 6;
        WriteLine("Your value was initialized with value {0}", someValue);

        // someValue++; This is a postfix increment as ++ is after the variable
        ++someValue; // This is a prefix increment as ++ is before the variable
        WriteLine("After increment, your value is {0}\n", someValue);

        /* It is very important to distinguish between postfix and prefix increments/decrements.
         * A prefix increment (++variable/--variable) calculates the increment/decrement, then stores it before it is used.
         * A postfix increment (variable++/variable--) the variable is used, then it is incremented/decremented and stored.
        */

        int b = 4;
        int c = ++b; // Prefix increment
        WriteLine("Prefix increment: value of b is {0} and value of c is {1}", b, c);

        b = 4;
        c = b++; // Postfix increment
        WriteLine("Postfix increment: value of b is {0} and value of c is {1}", b, c);

        b = 4;
        c = --b; // Prefix decrement
        WriteLine("Prefix decrement: value of b is {0} and value of c is {1}", b, c);

        b = 4;
        c = b--; // Postfix decrement
        WriteLine("Postfix decrement: value of b is {0} and value of c is {1}", b, c);

    }
}