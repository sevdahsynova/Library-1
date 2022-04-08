using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ViewModels.Windows
{
    public class AddSalaryViewModel : WindowViewModel
    {
        public AddSalaryViewModel()
        {
            Branches = new List<int>() { 0, 1, 2, 3, 4};
            AllEmployees = new List<int>() { 10, 11, 12, 13, 14, 20, 21, 22, 23, 24, 30, 31, 32, 33, 34, 35, 40, 41, 42, 43, 44 };
            Employees = new ObservableCollection<int>(AllEmployees);
        }


        private List<int> branches;
        public List<int> Branches
        {
            get => branches;
            set
            {
                branches = value;
                OnPropertyChanged(nameof(Branches));
            }
        }

        private int selectedBranch;
        public int SelectedBranch
        {
            get => selectedBranch;
            set
            {
                selectedBranch = value;

                Employees.Clear();
                foreach(var item in AllEmployees)
                {
                    if (value == 0)
                    {
                        Employees.Add(item);
                    }
                    else
                    {
                        if(item.ToString().StartsWith(value.ToString()))
                        {
                            Employees.Add(item);
                        }
                    }
                }

                OnPropertyChanged(nameof(SelectedBranch));
            }
        }

        public List<int> AllEmployees;


        private ObservableCollection<int> employees;
        public ObservableCollection<int> Employees
        {
            get => employees;
            set
            {
                employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }

    }
}
