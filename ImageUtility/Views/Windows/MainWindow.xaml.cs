using ImageUtility.ViewModels.Windows;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;



namespace ImageUtility.Views.Windows
{
    public partial class MainWindow : INavigationWindow
    {
        public MainWindowViewModel ViewModel { get; }

        public MainWindow(
            MainWindowViewModel viewModel,
            INavigationViewPageProvider navigationViewPageProvider,
            INavigationService navigationService, IContentDialogService dialogService
        )
        {
            ViewModel = viewModel;
            DataContext = this;

            SystemThemeWatcher.Watch(this);
            
            InitializeComponent();
            SetPageService(navigationViewPageProvider);
            
            navigationService.SetNavigationControl(RootNavigation);
            dialogService.SetDialogHost(RootContentDialog);
        }

        #region INavigationWindow methods

        public INavigationView GetNavigation() => RootNavigation;

        public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

        public void SetPageService(INavigationViewPageProvider navigationViewPageProvider) => RootNavigation.SetPageProviderService(navigationViewPageProvider);

        public void ShowWindow() => Show();

        public void CloseWindow() => Close();

        #endregion INavigationWindow methods

        /// <summary>
        /// Raises the closed event.
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        INavigationView INavigationWindow.GetNavigation()
        {
            throw new NotImplementedException();
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        //private void RootNavigation_ItemInvoked(object sender, EventArgs args)
        //{
        //    if (RootNavigation.SelectedItem is NavigationViewItem item)
        //    {
        //        var tag = item.Tag?.ToString();

        //        if (tag == "exit")
        //        {
        //            Application.Current.Shutdown();
        //            return;
        //        }
        //    }

        //}
    }
}
