using static System.Console;

class DefiningNamedConstants
{

    enum DayOfWeek
    {
        MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
    }

    static void Main()
    {
        /* Sometimes, we don't want to use variables, as they are "mutable", or can be changed.
         * In the case we want immutable values, we can create a named constant.
         * Constants are created by adding "const" before a data type in a declaration.
         * Programmers typically type constants in ALL_CAPS with underscores for readability.
         */

        const double TAX_RATE = 0.07; // Defines a constant value of type double named TAX_RATE


        // It's important to create constants for something that will never change. For example:
        const int INCHES_IN_A_FOOT = 12;

        int lengthInFeet = 6;
        int lengthInInches = lengthInFeet * INCHES_IN_A_FOOT;

        WriteLine("There are {0} inches in {1} feet.\n", lengthInInches, lengthInFeet);


        /* Enumerations are sets of constants represented by identifiers.
         * 
         * Enums must be placed outside of any methods within a class.
         * Typically, you'd put it after the class name and before the Main() method.
         * You create an enumerator by using the word "enum" followed by an identifier.
         * 
         * Example:
         * 
         * enum DayOfWeek 
         * {
         *    SUNDAY, MONDAY, TUESDAY, WEDNESDAY,
         *       THURSDAY, FRIDAY, SATURDAY
         * }
         * 
         * By default, an enum is an integer. You can specify it using "DayOfWeek:byte" for example
         * Identifiers also hold consecutive values. For example, SUNDAY is 0, MONDAY is 1, etc.
         * But, you can also assign a value to the first enum in a list, like so:
         * 
         * enum DayOfWeek 
         * {
         *    SUNDAY = 1, MONDAY, TUESDAY, WEDNESDAY,
         *       THURSDAY, FRIDAY, SATURDAY
         * }
         * 
         * In this case, SUNDAY is 1, MONDAY is 2, etc.
         * 
         * Or, you can simply define the values to be whatever you desire:
         * 
         * enum STREET_SPEEDS 
         * {
         *   SCHOOL_ZONE_SPEED = 20,
         *   CITY_STREET_SPEED = 45,
         *   HIGHWAY_SPEED = 65  
         * }
         * 
         */


        // Enums can also be used as their own "variable type".
        // We will use the "DayOfWeek" enum created in this class as an example.

        DayOfWeek payDay;
        payDay = DayOfWeek.FRIDAY;

        WriteLine("Payday is on {0}\n", payDay);


        // You can also convert enums to another type by casting

        int shippingDay;
        DayOfWeek deliveryDay;

        shippingDay = (int)DayOfWeek.THURSDAY; // Converts THURSDAY to its respective int position (3).
        deliveryDay = (DayOfWeek)shippingDay; // Converts shippingDay (3) back to the enum in position 3 (THURSDAY)

        WriteLine("{0} is position {1} in the enum list", deliveryDay, shippingDay);

    }
}