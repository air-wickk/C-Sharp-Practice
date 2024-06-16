using static System.Console;

class DemoVariables2
{
    static void Main()
    {
        int value1 = 24, value2 = 10, sum, diff, product, quotient, remainder;

        sum = value1 + value2;
        WriteLine("The sum of {0} + {1} = {2}", value1, value2, sum);

        diff = value1 - value2;
        WriteLine("The difference of {0} - {1} = {2}", value1, value2, diff);

        product = value1 * value2;
        WriteLine("The product of {0} * {1} = {2}", value1, value2, product);

        quotient = value1 / value2;
        remainder = value1 % value2;
        WriteLine("The quotient of {0} / {1} = {2} and the remainder is {3}", value1, value2, quotient, remainder);



    }
}
