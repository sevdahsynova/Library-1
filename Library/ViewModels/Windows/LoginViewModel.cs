using Library.Commands;
using Library.Models;
using System;
using System.Windows;

namespace Library.ViewModels
{
    public class LoginViewModel : WindowViewModel
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();


        public LoginCommand Login => new LoginCommand(this);

        private Visibility errorVisibility = Visibility.Collapsed;
        public Visibility ErrorVisibility
        {
            get => errorVisibility;
            set
            {
                errorVisibility = value;
                OnPropertyChanged(nameof(ErrorVisibility));
            }
        }

    }
}
