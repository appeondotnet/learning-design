using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class FileReaderProxy : IFileReader
    {
        private IFileReader _fileReader;
        private bool _isReader = false;

        public int Length
        {
            get
            {
                if (_fileReader == null)
                {
                    return -1;
                }

                return _fileReader.Length;
            }
        }

        public string Content 
        {
            get
            {
                if (_fileReader == null)
                {
                    return null;
                }

                return _fileReader.Content;
            }
        }

        public void ReadFile(string path)
        {
            if (_fileReader == null)
            {
                _fileReader = new FileReader();

                _fileReader.ReadFile(path);
            }
            else
            {
                _fileReader.ReadFile(path);
            }
        }
    }
}
