using Library.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.BranchCommands
{
    public abstract class BranchBaseCommand : BaseCommand
    {
        protected readonly BranchViewModel viewModel;
        public BranchBaseCommand(BranchViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

    }
}
