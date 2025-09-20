using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace ImageUtility.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        
        [ObservableProperty]
        private string _applicationTitle = "Image Utility";

        [ObservableProperty]
        private ObservableCollection<NavigationViewItem> _menuItems = 
        [
            new NavigationViewItem()
            {
                Content = "Home",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(Views.Pages.DashboardPage)
            },
            new NavigationViewItem()
            {
                Content = "Data",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                TargetPageType = typeof(Views.Pages.DataPage)
            },
            new NavigationViewItem()
            {
                Content = "Renamer",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Edit24 },
                TargetPageType = typeof(Views.Pages.RenamePage)
            }
        ];

        [ObservableProperty]
        private ObservableCollection<NavigationViewItem> _footerMenuItems =
        [
            new NavigationViewItem()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        ];

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems =
        [
            new MenuItem { Header = "Home", Tag = "tray_home" }
        ];
    }
}
