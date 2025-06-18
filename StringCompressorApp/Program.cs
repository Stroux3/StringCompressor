using StringCompressor.Core.Services;

class Program
{
    static void Main()
    {
        Compressor compressor = new ();

        string input = "aaabbcccdde";
        string compressed = compressor.Compress(input);
        string decompressedManual = compressor.DecompressManual(compressed);
        string decompressedWithRegex = compressor.DecompressWithRegex(compressed);


        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Compressed: {compressed}");
        Console.WriteLine($"DecompressedManual: {decompressedManual}");
        Console.WriteLine($"DecompressedWithRegex: {decompressedWithRegex}");
    }
}
