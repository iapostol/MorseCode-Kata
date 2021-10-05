using System.Collections.Generic;
using System.Linq;

namespace MorseCode_Kata
{
    public class MorseCodeConverter
    {
        private const char SPACE = ' ';
        private Dictionary<char, string> morseCodeMap;

        public MorseCodeConverter()
        {
            CreateMoseCodeMap();
        }

        private void CreateMoseCodeMap()
        {
            morseCodeMap = new()
            {
                { SPACE, "    " },
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
        }

        public string AlphanumericsFor(string morseCode)
        {
            var alphanumerics = string.Empty;

            var splittedMorseCode = morseCode.Split(SPACE);

            var isSpaceFound = false;

            for (var i = 0; i < splittedMorseCode.Length; i++)
            {
                if (splittedMorseCode[i].Length == 0 && !isSpaceFound)
                {
                    isSpaceFound = true;
                    alphanumerics += SPACE;
                    continue;
                }

                if (!string.IsNullOrEmpty(splittedMorseCode[i]))
                {
                    isSpaceFound = false;
                    alphanumerics += morseCodeMap.FirstOrDefault(x => x.Value == splittedMorseCode[i]).Key;
                }
            }

            return alphanumerics;
        }

        public string MorseCodeFor(string alphanumerics)
        {
            var upperAlphanumerics = alphanumerics.ToUpper();

            var morseCode = string.Empty;

            for (var i = 0; i < upperAlphanumerics.Length; i++)
            {
                if (morseCode.Length > 0 && upperAlphanumerics[i] != SPACE)
                    morseCode += SPACE;

                morseCode += morseCodeMap[upperAlphanumerics[i]];
            }

            return morseCode;
        }
    }
}