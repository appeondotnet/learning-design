using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProxyPattern
{
    class FileReader : IFileReader
    {
        public int Length { get; private set; }

        public string Content { get; private set; }

        public void ReadFile(string path)
        {
            this.Content = File.ReadAllText(path);

            this.Length = this.Content.Length;
        }
    }
}
