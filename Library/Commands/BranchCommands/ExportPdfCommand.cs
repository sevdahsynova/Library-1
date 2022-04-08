using Library.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.BranchCommands
{
    public class ExportPdfCommand : BranchBaseCommand
    {
        public ExportPdfCommand(BranchViewModel viewModel) : base(viewModel)
        {

        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
