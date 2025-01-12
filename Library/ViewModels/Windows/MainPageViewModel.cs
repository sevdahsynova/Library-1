﻿using Library.Commands.MainPageCommands;
using System;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class MainPageViewModel : WindowViewModel
    {

        public OpenBranchCommand OpenBranch => new OpenBranchCommand(this);
        public OpenBookCommand OpenBook => new OpenBookCommand(this);
        public OpenAddSalaryCommand OpenAddSalary => new OpenAddSalaryCommand(this);

        public Grid Grid { get; set; }

    }
}
