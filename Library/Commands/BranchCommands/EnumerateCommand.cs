using Library.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.BranchCommands
{
    public class EnumerateCommand : BranchBaseCommand
    {
        public EnumerateCommand(BranchViewModel viewModel) : base(viewModel)
        {

        }

        public override void Execute(object parameter)
        {
            int no = 1;
            foreach(var item in viewModel.Branches)
            {
                item.No = no;
                no++;
            }
        }
    }
}
