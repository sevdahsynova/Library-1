using LibraryCore.Domain.Abstract;
using LibraryCore.Factories;
using System;
using System.Windows.Input;

namespace Library.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        // BaseCommand doesn't know which actions must do in Execute method. So Execute method must be abstract
        public abstract void Execute(object parameter);


        protected IUnitOfWork DB => Kernel.Db;

    }
}
