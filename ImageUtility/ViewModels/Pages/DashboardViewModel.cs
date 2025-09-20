using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Wpf.Ui;
using Wpf.Ui.Controls;
using Wpf.Ui.Extensions;

namespace ImageUtility.ViewModels.Pages
{
    public partial class DashboardViewModel(ISnackbarService snackBar, IContentDialogService dialog) : ObservableObject
    {
        public ISnackbarService _snackBar = snackBar;
        public IContentDialogService _dialogService = dialog;

        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            _snackBar.Show("Counter incremented!", "Counter Button Pressed", appearance: ControlAppearance.Success, icon: new SymbolIcon(SymbolRegular.Folder48), TimeSpan.FromSeconds(5));
            if (Counter >= 10)
                Counter = 0;
            else
                Counter++;
        }


    }
}
