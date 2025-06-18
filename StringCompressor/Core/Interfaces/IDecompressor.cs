namespace StringCompressor.Core.Interfaces
{
    public interface IDecompressor
    {
        public string DecompressWithRegex(string input);
        public string DecompressManual(string input);
    }
}
