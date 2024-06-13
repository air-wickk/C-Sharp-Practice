using static System.Console;

class Chapter2Exercises
{

    enum MonthsOfYear 
    {
        JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY,
        AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }

    enum PlanetsInSystem
    {
        MERCURY = 1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
    }

    static void Main()
    {
        // Program to convert inches to centimeters

        int inches;
        const double CM_IN_INCH = 2.54;

        Write("Enter the number of inches: ");
        inches = Convert.ToInt32(ReadLine());
        double centimeters = CM_IN_INCH * inches;

        WriteLine("There are {0} centimeters in {1} inch(es).\n", centimeters, inches);


        // Program to calculate three salaries with a raise rate of 4%

        const double RAISE_RATE = 0.04;
        double salary1, salary2, salary3;
        int raisePercentage = (int)(RAISE_RATE * 100);

        Write("Enter salary 1: ");
        salary1 = Convert.ToDouble(ReadLine());
        Write("Enter salary 2: ");
        salary2 = Convert.ToDouble(ReadLine());
        Write("Enter salary 3: ");
        salary3 = Convert.ToDouble(ReadLine());

        salary1 += (RAISE_RATE * salary1);
        salary2 += (RAISE_RATE * salary2);
        salary3 += (RAISE_RATE * salary3);

        WriteLine("With a bonus of {0}% Employee 1 will make {1}, employee 2 will make {2}, and employee 3 will make {3}\n",
            raisePercentage, salary1.ToString("c"), salary2.ToString("c"), salary3.ToString("c"));


        // Program to calculate the cost of a moving company

        const int BASE_RATE = 200;
        const int PER_HOUR = 150;
        const int PER_MILE = 2;

        Write("Enter the number of hours spent moving: ");
        int numOfHours = Convert.ToInt32(ReadLine());

        Write("Enter the number of miles driven: ");
        int numOfMiles = Convert.ToInt32(ReadLine());

        double totalCost = BASE_RATE + (PER_HOUR * numOfHours) + (PER_MILE * numOfMiles);

        WriteLine("The total cost of the move is {0}\n", totalCost.ToString("c"));


        // Program to convert mins to hours and mins

        const int MINUTES_IN_HOUR = 60;

        Write("Enter the amount of time in minutes: ");
        int timeInMins = Convert.ToInt32(ReadLine());

        int numberOfHours = (timeInMins / MINUTES_IN_HOUR);
        int numberOfMins = (timeInMins % MINUTES_IN_HOUR);
        WriteLine("{0} minutes is equivalent to {1} hours and {2} minutes.\n", timeInMins, numberOfHours, numberOfMins);


        // Program to determine the number of eggs produced a month by four chickens

        Write("Enter the number of eggs the first chicken laid: ");
        int chicken1Eggs = Convert.ToInt32(ReadLine());
        Write("Enter the number of eggs the second chicken laid: ");
        int chicken2Eggs = Convert.ToInt32(ReadLine());
        Write("Enter the number of eggs the third chicken laid: ");
        int chicken3Eggs = Convert.ToInt32(ReadLine());
        Write("Enter the number of eggs the fourth chicken laid: ");
        int chicken4Eggs = Convert.ToInt32(ReadLine());

        int eggSum = chicken1Eggs + chicken2Eggs + chicken3Eggs + chicken4Eggs;
        int eggDozens = eggSum / 12;
        int eggRemainder = eggSum % 12;

        WriteLine("In total, the four chickens laid {0} eggs, coming out to a total of {1} dozen and {2} eggs.\n"
            , eggSum, eggDozens, eggRemainder);


        // Program to convert dollars to different types of change

        Write("Please enter an amount of money in dollars: $");
        int initialDollars = Convert.ToInt32(ReadLine());

        int hundreds = initialDollars / 100;
        int dollars = (initialDollars - (100 * hundreds));

        int fifties = dollars / 50;
        dollars = (dollars - (50 * fifties));

        int twenties = dollars / 20;
        dollars = (dollars - (20 * twenties));

        int tens = dollars / 10;
        dollars = (dollars - (10 * tens));

        int fives = dollars / 5;
        dollars = (dollars - (5 * fives));

        int ones = dollars / 1;

        WriteLine("${0} can be turned into {1} hundreds, {2} fifties, {3} twenties, {4} tens, {5} fives and {6} ones.\n"
            , initialDollars, hundreds, fifties, twenties, tens, fives, ones);


        // Program to take the average of 8 test scores (rounded to two decimal places)

        Write("Enter test score 1: ");
        double score1 = Convert.ToDouble(ReadLine());
        Write("Enter test score 2: ");
        double score2 = Convert.ToDouble(ReadLine());
        Write("Enter test score 3: ");
        double score3 = Convert.ToDouble(ReadLine());
        Write("Enter test score 4: ");
        double score4 = Convert.ToDouble(ReadLine());
        Write("Enter test score 5: ");
        double score5 = Convert.ToDouble(ReadLine());
        Write("Enter test score 6: ");
        double score6 = Convert.ToDouble(ReadLine());
        Write("Enter test score 7: ");
        double score7 = Convert.ToDouble(ReadLine());
        Write("Enter test score 8: ");
        double score8 = Convert.ToDouble(ReadLine());

        double averageScore = ((score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8) / 8);

        WriteLine("The average test score is {0}%\n", averageScore.ToString("F2"));


        // Program to convert Fahrenheit to Celsius

        const double SUBTRACT_32 = 32.0;
        const double FRACTION_MULTIPLY = (5.0 / 9.0);

        Write("Enter a temperature in Fahrenheit: ");
        double tempF = Convert.ToDouble(ReadLine());
        double tempC = (tempF - SUBTRACT_32) * FRACTION_MULTIPLY;

        WriteLine("{0} degrees Fahrenheit is equal to {1} degrees Celsius.\n", tempF.ToString("F1"), tempC.ToString("F1"));


        // Program to convert integers to the 12 months of the year
        // See top of file for enums

        Write("Please enter an integer (1-12) to return its respective month: ");
        int monthValue = Convert.ToInt32(ReadLine());

        MonthsOfYear month;
        month = (MonthsOfYear)monthValue;

        WriteLine("You chose {0} which corresponds with {1}.\n", monthValue, month);


        // Program to convert integers to enums for the 8 planets
        // See top of file for enums

        Write("Please enter an integer (1-8) to return its respective planet: ");
        int planetValue = Convert.ToInt32(ReadLine());

        PlanetsInSystem planet;
        planet = (PlanetsInSystem)planetValue;

        WriteLine("You chose {0} which corresponds to {1}.\n", planetValue, planet);


        // Program to translate words to pig latin

        Write("Please enter a word you'd like to convert to pig latin: ");
        string wordToConvert = ReadLine();

        string endPart = "ay";
        string firstLetter = wordToConvert.Substring(0, 1);
        string restOfWord = wordToConvert.Substring(1, wordToConvert.Length - 1);

        string newWord = restOfWord + firstLetter + endPart;
        WriteLine("{0} in pig latin is {1}", wordToConvert, newWord);





    }
}