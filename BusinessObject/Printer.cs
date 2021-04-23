using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessObject
{
    public class Printer
    {
        public int EngenPrintersID { get; set; }
        public string PrinterName { get; set; }
        public string FolderToMonitor { get; set; }
        public string OutputType { get; set; }
        public string FileOutput { get; set; }
        public Nullable<int> PrinterMakeID { get; set; }
        public int Active { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModificationDate { get; set; }

        public virtual PrinterMake PrinterMake { get; set; }
    }
}