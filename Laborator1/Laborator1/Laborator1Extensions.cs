using System;
namespace Laborator1
{
    public static class Laborator1Extensions
    {
        /**
         * Extension that will split a string into an array of words.
         */
        public static string[] SplitToWords(this String originalString)
        {
            string processed = originalString ?? "";
            return processed.Split(new char[] { ' ', '.', '?', ':', ',', '(', ')', '[', ']', '}', '}' },
                             StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
