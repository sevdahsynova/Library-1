using Library.Commands.BranchCommands;
using Library.Models;
using Library.Utils;
using LibraryCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Library.ViewModels.UserControls
{
    public class BranchViewModel : UCViewModel
    {
        public BranchViewModel()
        {
            Header = "Filiallar";
        }

        public void InitializeViewModel()
        {
            CurrentBranch = new BranchModel();
            CurrentSituation = (int)Constants.SITUATIONS.NORMAL;
            SelectedBranch = null;
            Branches = new List<BranchModel>(AllBranches);
            Enumerate.Execute(null);
        }

        public SaveCommand Save => new SaveCommand(this);
        public RejectCommand Reject => new RejectCommand(this);
        public DeleteCommand Delete => new DeleteCommand(this);
        public EnumerateCommand Enumerate => new EnumerateCommand(this);
        public ExportExcelCommand ExportExcel => new ExportExcelCommand(this);
        public ExportPdfCommand ExportPdf => new ExportPdfCommand(this);


        private BranchModel currentBranch;
        public BranchModel CurrentBranch
        {
            get => currentBranch;
            set
            {
                currentBranch = value;
                OnPropertyChanged(nameof(CurrentBranch));
            }
        }

        private BranchModel selectedBranch;
        public BranchModel SelectedBranch
        {
            get => selectedBranch;
            set
            {
                selectedBranch = value;
                if(value != null)
                {
                    CurrentBranch = SelectedBranch;
                    CurrentSituation = (int)Constants.SITUATIONS.SELECTED;
                }
                OnPropertyChanged(nameof(SelectedBranch));
            }
        }

        public List<BranchModel> AllBranches;

        private List<BranchModel> branches;
        public List<BranchModel> Branches
        {
            get => branches ?? (branches = new List<BranchModel>());
            set
            {
                branches = value;
                OnPropertyChanged(nameof(Branches));
            }
        }


        private string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                // search here
                searchText = value;

                if (string.IsNullOrEmpty(value))
                {
                    // return all list;
                    Branches = new List<BranchModel>(AllBranches);
                }
                else
                {
                    // lambda
                    Branches = AllBranches.Where(x => x.Contains(searchText)).ToList();
                    #region commented lines

                    //var filteredList = new List<BranchModel>();
                    //foreach(var x in branches)
                    //{
                    //    if(x.Contains(searchText))
                    //    {
                    //        filteredList.Add(x);
                    //    }
                    //}

                    //branches = filteredList;

                    #endregion
                }

                Enumerate.Execute(null);
            }
        }

    }
}
