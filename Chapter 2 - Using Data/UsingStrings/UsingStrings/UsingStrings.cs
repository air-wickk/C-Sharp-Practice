using static System.Console;
using static System.String;

class UsingStrings
{
    static void Main()
    {

        /* A string is a series of characters, expressed in double quotes "like this"
         * Strings can be compared using == and !=
         * For example, Amy == Amy is true, but Amy == Joe is false
         */

        string name1 = "Amy";
        string name2 = "Amy";
        string name3 = "Joe";

        WriteLine("Compare {0} to {1}: {2}", name1, name2, name1 == name2); // Compare Amy to Amy
        WriteLine("Compare {0} to {1}: {2}", name1, name3, name1 == name3); // Compare Amy to Joe
        WriteLine();


        // Strings can be compared with any of the following methods.

        // The Equals() method, which returns true/false:
        name1.Equals(name2);


        // The CompareTo() method, which returns an integer. 0 when they are equal, negative if the first string is less,
        // and a positive number if the second string (the one in parentheses) is less:
        name1.CompareTo(name2);


        // The Compare() method, which also returns an integer. 0 when they are equal, negative if the first string is less,
        // and a positive number if the second string (the one in parentheses) is less.
        // To use Compare(), you must import another library: "using static System.String"
        Compare(name1, name2);


        // Below is an example of a program using the methods listed above:

        name1 = "Bob";
        name2 = "Bob";
        name3 = "Jonathan";

        // Equals()
        WriteLine("{0} and {1}; Equals() method will return {2}", name1, name2, name1.Equals(name2));
        WriteLine("{0} and {1}; Equals() method will return {2}\n", name1, name3, name1.Equals(name3));

        // CompareTo()
        WriteLine("{0} and {1}; CompareTo() method will return {2}", name1, name2, name1.CompareTo(name2));
        WriteLine("{0} and {1}; CompareTo() method will return {2}", name1, name3, name1.CompareTo(name3));
        WriteLine("{0} and {1}; CompareTo() method will return {2}\n", name3, name1, name3.CompareTo(name1));

        // Compare()
        WriteLine("{0} and {1}; Compare() method will return {2}", name1, name2, Compare(name1, name2));
        WriteLine("{0} and {1}; Compare() method will return {2}", name1, name3, Compare(name1, name3));
        WriteLine("{0} and {1}; Compare() method will return {2}\n", name3, name1, Compare(name3, name1));


        // In addition to comparison methods, you can use properties and methods to determine the qualities of a string

        // The Length property determines a string's length. It is NOT a method and will not have parentheses. (returns int)
        string word = "water";
        WriteLine("The length of the string \"{0}\" is {1}\n", word, word.Length);


        // The Substring() method can extract a portion of any given string at any specified starting position
        // The first character in a string is at position 0, and the last character is at position Length – 1
        // The method reads as word.Substring(start position, length)
        // Position: 0 1 2 3 4
        //   String: w a t e r
        WriteLine("The substring between index 0 and 1 for the word {0} is {1}", word, word.Substring(0, 1));
        WriteLine("The substring between index 0 and 2 for the word {0} is {1}", word, word.Substring(0, 2));
        WriteLine("The substring between index 1 and 2 for the word {0} is {1}", word, word.Substring(1, 2));
        WriteLine("The substring between index 2 and 3 for the word {0} is {1}", word, word.Substring(2, 3));
        WriteLine("The substring between index 0 and the end of the word {0} is {1}\n", word, word.Substring(0, word.Length));
        // word.Substring(3, 4) would return an error as there isn't enough characters to fill a length of 4 starting at position 3


        // The StartsWith() method determines whether or not a string starts with specified characters. (returns t/f)
        WriteLine("The string {0} starts with the letters \"wa\": {1}", word, word.StartsWith("wa"));
        WriteLine("The string {0} starts with the letters \"wae\": {1}", word, word.StartsWith("wae"));

    }
}