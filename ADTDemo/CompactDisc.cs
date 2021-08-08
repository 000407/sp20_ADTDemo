using System;

namespace ADTDemo
{
    class CompactDisc
    {
        private bool isWritten;

        public string Label
        {
            get; set;
        }

        public byte[] Content
        {
            get; private set;
        }

        public void Write(byte[] content)
        {
            if (isWritten)
            {
                throw new Exception("The disc is already written!");
            }

            Content = content; //Writing to the disc
            isWritten = true;
        }
    }
}
