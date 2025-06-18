using StringCompressor.Core.Services;

class Program
{
    static void Main()
    {
        var compressor = new Compressor();

        string input = "aaabbcccdde";
        string compressed = compressor.Compress(input);
        string decompressed = compressor.DecompressManual(compressed);

        Console.WriteLine($"Input:        {input}");
        Console.WriteLine($"Compressed:   {compressed}");
        Console.WriteLine($"Decompressed: {decompressed}");
    }
}
