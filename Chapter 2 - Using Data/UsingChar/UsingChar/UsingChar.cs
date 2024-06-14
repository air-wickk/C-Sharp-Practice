using static System.Console;

class UsingChar
{
    static void Main()
    {

        /* A char stores practically any single character
         * Meaning it can be letters, numbers, or even non-printing characters like tab and backspace
         * Chars are represented in singular quotes like this: 'e'
         */

        char initial = 'D';
        char aCharValue = '9'; // Cannot be used in arithmetic as it is not a numeric type

        // These are called escape sequences
        char aBackspaceChar = '\b';
        char aTabChar = '\t';

        /* A full list of escape sequences is as follows:
         * 
         * Escape Sequence           Character Name
         * -------------------------------------------------
         *  \'                       singular quotation mark
         *  \''                      double quotation mark
         *  \\                       backslash
         *  \0                       null
         *  \a                       alert
         *  \b                       backspace
         *  \f                       form feed
         *  \n                       newline
         *  \r                       carriage return
         *  \t                       horizontal tab
         *  \v                       vertical tab
         */
    }
}