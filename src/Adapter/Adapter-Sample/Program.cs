using System;
using System.IO;
using System.IO.Compression;

namespace Adapter_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = File.OpenRead("text.txt");

            stream = new GZipStream(stream, CompressionMode.Decompress);

            AdapteInvoke(stream);
        }

        static void AdapteInvoke(Stream stream)
        {
            var reader = new StreamReader(stream);

            Adapte(reader);
        }

        static void Adapte(TextReader reader)
        {
        }
    }
}
