using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyPrinterAPI.Models
{
    public class Printer
    {
        public int PrinterID { get; set; }
        public string PrinterName { get; set; }
        public string FolderToMonitor { get; set; }
        public string OutputType { get; set; }
        public string FileOutput { get; set; }
        public Nullable<int> PrinterMakeID { get; set; }
        public byte Active { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModificationDate { get; set; }

        public virtual PrinterMake PrinterMake { get; set; }
    }
}