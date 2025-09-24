using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImageUtility.Views.Pages;
using ImageUtility.Views.Windows;
using Microsoft.Win32;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace ImageUtility.ViewModels.Pages
{
    public partial class DashboardViewModel(ISnackbarService snackBar, INavigationService navigationService) : ObservableObject
    {
        private readonly INavigationService _navigationService = navigationService;
        private readonly ISnackbarService _snackbarService = snackBar;

        [RelayCommand]
        private void OnNavigate(string args)
        {
            switch (args)
            {
                case "settings":
                    _navigationService.Navigate(typeof(SettingsPage));
                    break;
                case "contact_us":
                    _navigationService.Navigate(typeof(RenamePage));
                    break;
                case "dashboard":
                    _navigationService.Navigate(typeof(DashboardPage));
                    break;
                default:
                    throw new Exception("no view to navigate to");

            }
            ;
           
        }

    }
}
