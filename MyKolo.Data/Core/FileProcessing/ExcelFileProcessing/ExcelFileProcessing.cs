using IronXL;
using MyKolo.Data.Core.Constant;
using MyKolo.Data.Core.FileProcessing.FileProcessor;
using MyKolo.Data.Core.FileProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKolo.Data.Core.FileProcessing.ExcelFileProcessing
{
    public class ExcelFileProcessing : FIleProcessBase, IFileProcessor
    {
        private WorkBook dbFile;
        private string dbFileName = "MyKoloDb.xls";
        public ExcelFileProcessing() : base()
        {
            if(!File.Exists(Path.Combine(filePath,dbFileName)))
            {
                //Create new Excel WorkBook document. 
                //The default file format is XLSX, but we can override that for legacy support
                this.dbFile = WorkBook.Create(ExcelFileFormat.XLS);
                dbFile.Metadata.Author = "SBSC Emmanuel";
              
                //Add a blank WorkSheet
                WorkSheet savingTable = dbFile.CreateWorkSheet("Savings");
                WorkSheet ExpenseTable = dbFile.CreateWorkSheet("Savings");
              
                //Add data and styles to the new worksheet
                savingTable["A1"].Value = "ID";
                savingTable["B1"].Value = "CREATED DATE TIME";
                savingTable["C1"].Value = "AMOUNT";
                savingTable["D1"].Value = "DESCRIPTION";
                savingTable["A2"].Style.BottomBorder.SetColor("#ff6600");
                savingTable["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;

                ExpenseTable["A1"].Value = "ID";
                ExpenseTable["B1"].Value = "CREATED DATE TIME";
                ExpenseTable["C1"].Value = "AMOUNT";
                ExpenseTable["D1"].Value = "DESCRIPTION";
                ExpenseTable["A2"].Style.BottomBorder.SetColor("#ff6600");
                ExpenseTable["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;

                //Save the excel file
                dbFile.Save();
            }
            
        }
        public bool ReadFromFile()
        {
            return true;
        }

        public bool WriteToFile()
        {
            return true;
        }
    }
}
