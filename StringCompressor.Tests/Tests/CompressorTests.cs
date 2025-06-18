using StringCompressor.Core.Services;
using Xunit;

namespace StringCompressor.Tests
{
    public class CompressorTests
    {
        private Compressor compressorUnitTest = new();

        [Theory]
        [InlineData("aaabbcccdde", "a3b2c3d2e")]
        [InlineData("abcd", "abcd")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("aabbcc", "a2b2c2")]
        public void Compress_WorksCorrectly(string input, string expected )
        {
            var result = compressorUnitTest.Compress(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("a3b2c3d2e", "aaabbcccdde")]
        [InlineData("abcd", "abcd")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("a2b2c2", "aabbcc")]
        public void DecompressWithRegex_WorksCorrectly(string input, string expected)
        {
            var result = compressorUnitTest.DecompressWithRegex(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("a3b2c3d2e", "aaabbcccdde")]
        [InlineData("abcd", "abcd")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("a2b2c2", "aabbcc")]
        public void DecompressManual_WorksCorrectly(string input, string expected)
        {
            var result = compressorUnitTest.DecompressManual(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Compress_ThenDecompress_ReturnsOriginal()
        {
            var original = "zzzzaaaabbbbccccdddddeeee";
            var compressed = compressorUnitTest.Compress(original);
            var decompressedWithRegex = compressorUnitTest.DecompressWithRegex(compressed);
            var decompressedManual = compressorUnitTest.DecompressManual(compressed);
            Assert.Equal(original, decompressedWithRegex);
            Assert.Equal(original, decompressedManual);
        }
    }

}
