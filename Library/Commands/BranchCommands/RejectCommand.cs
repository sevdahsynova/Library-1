using Library.Utils;
using Library.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.BranchCommands
{
    public class RejectCommand : BranchBaseCommand
    {
        public RejectCommand(BranchViewModel viewModel) : base(viewModel)
        {

        }

        public override void Execute(object parameter)
        {
            viewModel.InitializeViewModel();
        }
    }
}
