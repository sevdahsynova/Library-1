using LibraryCore.Domain.Abstract;
using LibraryCore.Factories;
using System;
using System.ComponentModel;

namespace Library.ViewModels
{
    // you can not create object for BaseViewModel, because it is abstract class
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected IUnitOfWork DB => Kernel.Db;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
