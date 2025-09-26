using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImageUtility.Views.Pages;
using System.Collections.ObjectModel;
using System.Windows;
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
                Content = "Dashboard",
                Tag = "dashboard",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(DashboardPage)
            },
            new NavigationViewItem()
            {
                Content = "Data",
                Tag = "Data",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                TargetPageType = typeof(DataPage)
            },
            new NavigationViewItem()
            {
                Content = "Renamer",
                Tag = "renamer",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Edit24 },
                TargetPageType = typeof(RenamePage)
            },
            new NavigationViewItem()
            {
                Content = "Resize",
                Tag = "resizer",
                Icon = new SymbolIcon { Symbol = SymbolRegular.ResizeImage24 },
                TargetPageType = typeof(ResizePage)
            },
           
        ];

        [ObservableProperty]
        private ObservableCollection<NavigationViewItem> _footerMenuItems =
        [
             new NavigationViewItem()
            {
                Content = "Settings",
                Tag = "settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(SettingsPage)
            },

        ];

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems =
        [
            new MenuItem { Header = "Home", Tag = "tray_home" }
        ];
    }
}
