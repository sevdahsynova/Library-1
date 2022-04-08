using Library.ViewModels;

namespace Library.Commands.MainPageCommands
{
    public abstract class MainPageBaseCommand : BaseCommand
    {
        protected readonly MainPageViewModel viewModel;
        public MainPageBaseCommand(MainPageViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
    }
}
