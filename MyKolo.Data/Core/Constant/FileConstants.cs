using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKolo.Data.Core.Constant
{
    public class FileConstants
    {
        public readonly static string DBFOLDER = Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.Desktop), "MyKolo");
    }
}
