using static System.Console;

class DemoVariables
{
    static void Main()
    {
        int anInt = -132;
        uint anUnsignedInt = 567;

        WriteLine("The signed int is {0} and the unsigned int is {1}", anInt, anUnsignedInt);


        // Visit page 61 in the textbook to learn more about format characters like F, used below
        double money = 320;
        string moneyString;
        moneyString = money.ToString("F");
        WriteLine("This is going to display the money as a double with 2 fixed decimal places: {0}", moneyString);
        moneyString = money.ToString("F3");
        WriteLine("This is going to display the money as a double with 3 fixed decimal places: {0}", moneyString);

        double moneyValue = 324000;
        string moneyValueString = moneyValue.ToString("C");
        WriteLine("The amount of money is: {0}", moneyValueString);

        // A quicker way of doing so is as follows
        double payAmount = 12345;
        WriteLine("After the quicker exmaple, it still prints as: " + payAmount.ToString("c"));

    }
}