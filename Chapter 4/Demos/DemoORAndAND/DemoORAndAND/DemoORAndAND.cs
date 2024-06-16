using static System.Console;

class DemoOrAndAND
{
    static void Main()
    {

        const int ZONE1 = 1, ZONE2 = 2;
        const int LOW_QUANTITY = 10;
        int quantity;
        int deliveryZone;

        WriteLine("Delivery is free for zone {0} or {1} and when the number of packages " +
            "is less than {2}", ZONE1, ZONE2, LOW_QUANTITY);

        Write("Enter delivery zone: ");
        deliveryZone = Convert.ToInt32(ReadLine());

        Write("Enter number of packages: ");
        quantity = Convert.ToInt32(ReadLine());

        if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity < LOW_QUANTITY)
            WriteLine("Shipping is free.");
        else
            WriteLine("Shipping is not free.");

    }
}