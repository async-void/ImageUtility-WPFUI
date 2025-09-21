using ImageUtility.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace ImageUtility.Views.Pages
{
    /// <summary>
    /// Interaction logic for RenamePage.xaml
    /// </summary>
    public partial class RenamePage : INavigableView<RenameViewModel>
    {
        public RenameViewModel ViewModel { get; }
        public RenamePage(RenameViewModel vm)
        {
            ViewModel = vm;
            DataContext = this;

            InitializeComponent();
 
        }

    }
}
