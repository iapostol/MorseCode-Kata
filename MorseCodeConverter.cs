using System.Collections.Generic;
using System.Linq;

namespace MorseCode_Kata
{
    public static class MorseCodeConverter
    {
        private static readonly Dictionary<char, string> AlphanumericToMorseCode = new()
        {
            { ' ', "    " },
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },
            { '0', "-----" },
            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." }
        };

        public static string AlphanumericsFor(string morseCode)
        {
            var alphanumerics = "";

            var splittedMorseCode = morseCode.Split(" ");

            var isSpaceFound = false;

            for (var i = 0; i < splittedMorseCode.Length; i++)
            {
                if (splittedMorseCode[i].Length == 0 && !isSpaceFound)
                {
                    isSpaceFound = true;
                    alphanumerics += " ";
                    continue;
                }

                if (!string.IsNullOrEmpty(splittedMorseCode[i]))
                {
                    isSpaceFound = false;
                    alphanumerics += AlphanumericToMorseCode.FirstOrDefault(x => x.Value == splittedMorseCode[i]).Key;
                }
            }

            return alphanumerics;
        }

        public static string MorseCodeFor(string alphanumerics)
        {
            var upperAlphanumerics = alphanumerics.ToUpper();

            var morseCode = "";

            for (var i = 0; i < upperAlphanumerics.Length; i++)
            {
                if (morseCode.Length > 0 && upperAlphanumerics[i] != ' ')
                    morseCode += ' ';

                morseCode += AlphanumericToMorseCode[upperAlphanumerics[i]];
            }

            return morseCode;
        }
    }
}