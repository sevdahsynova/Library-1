using ClosedXML.Excel;
using Library.Attributes;
using Library.Models;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Library.Utils
{
    public class ExcelWriter<T> where T : BaseModel
    {
        // using techniques:
        // 1. reflection
        // 2. attributes
        // 3. indexes

        public static void Write(List<T> models, string fileName)
        {
            var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Models");

            DataTable table = new DataTable();

            var type = typeof(T);
            var fullProperties = type.GetProperties();

            var exportProperties = new List<PropertyInfo>();

            foreach (var prop in fullProperties)
            {
                var attribute = prop.GetCustomAttribute(typeof(ExportAttribute));
                if (attribute != null)
                {
                    exportProperties.Add(prop);
                }
            }

            foreach (var prop in exportProperties)
            {
                var attribute = prop.GetCustomAttribute(typeof(ExportAttribute)) as ExportAttribute;
                table.Columns.Add(attribute.ColumnName);
            }

            foreach (var model in models)
            {
                List<object> rowValues = new List<object>();
                foreach (var property in exportProperties)
                {
                    var value = model[property.Name];
                    rowValues.Add(value);
                }

                table.Rows.Add(rowValues.ToArray());
            }

            worksheet.Cell(1, 1).InsertTable(table);
            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(fileName);
        }
    }
}
