using ClosedXML.Excel;
using Library.Models;
using Library.Utils;
using Library.ViewModels.UserControls;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Data;

namespace Library.Commands.BranchCommands
{
    public class ExportExcelCommand : BranchBaseCommand
    {
        public ExportExcelCommand(BranchViewModel viewModel) : base(viewModel)
        {

        }

        public override void Execute(object parameter)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                #region for testing 

                //var test = new List<BookModel>();
                //test.Add(new BookModel()
                //{
                //    Id = 1,
                //    Name = "Əlifba",
                //    No = 1,
                //    Price = 2.45M,
                //    Writer = "XXX"
                //});

                //test.Add(new BookModel()
                //{
                //    Id = 1,
                //    Name = "Test",
                //    No = 1,
                //    Price = 5.75M,
                //    Writer = "ZZZ"
                //});

                //ExcelWriter<BookModel>.Write(test, dialog.FileName);

                #endregion

                ExcelWriter<BranchModel>.Write(viewModel.Branches, dialog.FileName);
                //ExportExcel(dialog.FileName);
            }
        }


        private void ExportExcel(string fileName)
        {
            var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Branches");

            DataTable table = new DataTable();
            table.Columns.Add("No");
            table.Columns.Add("Name");
            table.Columns.Add("Address");
            table.Columns.Add("Phone");
            table.Columns.Add("Note");

            foreach (var branch in viewModel.Branches)
            {
                table.Rows.Add(branch.No, branch.Name, branch.Address, branch.PhoneNumber, branch.Note);
            }

            worksheet.Cell(1, 1).InsertTable(table);
            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(fileName);
        }

    }
}
