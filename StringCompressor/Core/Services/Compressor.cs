using StringCompressor.Core.Interfaces;
using System.Text;
using System.Text.RegularExpressions;

namespace StringCompressor.Core.Services
{
    internal class Compressor : ICompressor, IDecompressor
    {
        #region Компрессия
        /// <summary>
        /// Сжимает строку, заменяя последовательности одинаковых букв вида "aaa" на "a3"
        /// </summary>
        public string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var result = new StringBuilder();
            int count = 1;
            for (int i = 1; i <= input.Length; i++)
            {
                if (i < input.Length && input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    result.Append(input[i - 1]);
                    if (count > 1)
                        result.Append(count);
                    count = 1;
                }
            }

            return result.ToString();
        }
        #endregion

        #region Декомпрессия
        /// <summary>
        /// Восстанавливает строку из сжатой формы вида "a3b2" в вид "aaabb" с помощью Regex
        /// </summary>
        public string DecompressWithRegex(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            var result = new StringBuilder();
            var regex = new Regex(@"([a-z])(\d*)");
            foreach (Match match in regex.Matches(input))
            {
                char ch = match.Groups[1].Value[0];
                int count = string.IsNullOrEmpty(match.Groups[2].Value) ? 1 : int.Parse(match.Groups[2].Value);
                result.Append(new string(ch, count));
            }
            return result.ToString();
        }

        /// <summary>
        /// Восстанавливает строку из сжатой формы вида "a3b2" в вид "aaabb" с помощью Regex
        /// </summary>
        public string DecompressManual(string input) 
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var sb = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {
                char currentChar = input[i];
                i++;
                int count = 0;
                while (i < input.Length && char.IsDigit(input[i]))
                {
                    count = count * 10 + (input[i] - '0');
                    i++;
                }

                if (count == 0) count = 1;

                sb.Append(new string(currentChar, count));
            }

            return sb.ToString();
        }
        #endregion
    }

}
    

