using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    interface IFileReader
    {
        int Length { get; }
        string Content { get; }
        void ReadFile(string path);
    }
}
