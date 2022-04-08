using Library.ViewModels;
using Library.ViewModels.Windows;
using Library.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.MainPageCommands
{
    public class OpenAddSalaryCommand : MainPageBaseCommand
    {
        public OpenAddSalaryCommand(MainPageViewModel viewModel) : base(viewModel)
        {
        }

        public override void Execute(object parameter)
        {
            AddSalaryWindow window = new AddSalaryWindow();
            AddSalaryViewModel viewModel = new AddSalaryViewModel();
            window.DataContext = viewModel;
            window.ShowDialog();
        }
    }
}
