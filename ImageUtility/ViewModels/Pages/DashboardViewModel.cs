using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace ImageUtility.ViewModels.Pages
{
    public partial class DashboardViewModel(ISnackbarService snackBar) : ObservableObject
    {
        public ISnackbarService _snackBar = snackBar;
        //public IContentDialogService _dialogService = dialog;

        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            _snackBar.Show("Counter incremented!", "Counter Button Pressed", appearance: ControlAppearance.Success, null, TimeSpan.FromSeconds(3));
            if (Counter >= 10)
                Counter = 0;
            else
                Counter++;
        }


    }
}
