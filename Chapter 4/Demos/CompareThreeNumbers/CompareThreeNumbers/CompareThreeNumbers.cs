using static System.Console;

class CompareThreeNumbers
{
    static void Main()
    {
        int num1, num2, num3;

        Write("Enter an integer: ");
        num1 = Convert.ToInt32(ReadLine());

        Write("Enter an integer: ");
        num2 = Convert.ToInt32(ReadLine());

        Write("Enter an integer: ");
        num3 = Convert.ToInt32(ReadLine());

        if (num1 == num2)
        {
            if (num3 == num1)
                WriteLine("All three numbers are equal.");
            else
                WriteLine("The first two numbers are equal.");
        }
        else if (num3 == num1)
            WriteLine("The first and last number are equal.");
        else if (num2 == num3)
            WriteLine("The second and last number are equal.");
        else
            WriteLine("No two numbers are equal.");

    }
}