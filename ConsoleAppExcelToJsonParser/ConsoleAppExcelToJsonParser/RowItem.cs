using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExcelToJsonParser
{
    public class RowItem
    {
        public int RowNr { get; set; }
        public ICollection<ColumnItem> Columns { get; set; }

        public RowItem(int rowNr)
        {
            RowNr = rowNr;
            Columns=new List<ColumnItem>();
        }
    }
}
