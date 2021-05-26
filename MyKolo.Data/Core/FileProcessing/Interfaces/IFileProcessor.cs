using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKolo.Data.Core.FileProcessing.Interfaces
{
    internal interface IFileProcessor
    {
        bool ReadFromFile();
        bool WriteToFile();
    }
}
