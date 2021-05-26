using MyKolo.Data.Core.Constant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKolo.Data.Core.FileProcessing.FileProcessor
{
    public class FIleProcessBase
    {
        protected string filePath = FileConstants.DBFOLDER;
        public FIleProcessBase()
        {
            
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }
    }
}
