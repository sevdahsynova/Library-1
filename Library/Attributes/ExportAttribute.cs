using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Attributes
{
    public class ExportAttribute : Attribute
    {
        private string columnName;
        private int columnOrder;
        public ExportAttribute(string columnName, int columnOrder)
        {
            this.columnName = columnName;
            this.columnOrder = columnOrder;
        }

        public string ColumnName => columnName;
        public int ColumnOrder => columnOrder;

    }
}
