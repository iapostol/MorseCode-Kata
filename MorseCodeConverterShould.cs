using Xunit;

namespace MorseCode_Kata
{
    public class MorseCodeConverterShould
    {
        private readonly MorseCodeConverter converter;

        public MorseCodeConverterShould()
        {
            converter = new MorseCodeConverter();
        }
        [Theory]
        [InlineData(".-", "A")]
        [InlineData(".- .-", "AA")]
        [InlineData(".- .- .-", "AAA")]
        [InlineData("-----", "0")]
        [InlineData(".. --- -.", "ION")]
        [InlineData("-- --- .-. ... .     -.-. --- -.. .", "MORSE CODE")]
        [InlineData("... --- ...", "SOS")]
        [InlineData("..---     .. ...     --. .-. . .- - . .-.     - .... .- -.     .----", "2 IS GREATER THAN 1")]
        public void Convert_MorseCode_For_Given_Alphanumerics(string morseCode, string alphanumerics)
        {
            Assert.Equal(morseCode, converter.MorseCodeFor(alphanumerics));
        }

        [Theory]
        [InlineData("A", ".-")]
        [InlineData("AA", ".- .-")]
        [InlineData("SOS", "... --- ...")]
        [InlineData("A A", ".-     .-")]
        [InlineData("MORSE CODE", "-- --- .-. ... .     -.-. --- -.. .")]
        [InlineData("2 IS GREATER THAN 1", "..---     .. ...     --. .-. . .- - . .-.     - .... .- -.     .----")]
        public void Convert_Alphanumerics_For_Given_MorseCode(string alphanumerics, string morseCode)
        {
            Assert.Equal(alphanumerics, converter.AlphanumericsFor(morseCode));
        }
    }
}
