using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zoo
{
    interface IOutput
    {
        void FileOutput(StreamWriter f);
    }
}
