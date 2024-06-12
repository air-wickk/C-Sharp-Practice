using static System.Console;

class DemoVariables3
{
    static void Main()
    {
        int comparisonValue = 4;
        bool isSixMore = 6 > comparisonValue;

        WriteLine("Is 6 more than {0}? {1}", comparisonValue, isSixMore);

        comparisonValue = 35;
        isSixMore = 6 > comparisonValue;

        WriteLine("Is 6 more than {0}? {1}", comparisonValue, isSixMore);

    }
}