using static System.Console;

class InteractiveAddition
{
    static void Main()
    {

        string name;
        int first, second, sum;

        Write("Enter your name: ");
        name = ReadLine();

        Write("Hello {0}! Enter the first integer: ", name);
        first = Convert.ToInt32(ReadLine());
        Write("Enter the second integer: ");
        second = Convert.ToInt32(ReadLine());

        sum = first + second;

        WriteLine("{0}, the sum of {1} and {2} is {3}.",
            name, first, second, sum);

    }
}