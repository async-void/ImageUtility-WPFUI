using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using ImageUtility.Models;
using Wpf.Ui.Abstractions.Controls;

namespace ImageUtility.ViewModels.Pages
{
    public partial class DataViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        [ObservableProperty]
        private IEnumerable<DataColor> _colors;

        public Task OnNavigatedToAsync()
        {
            if (!_isInitialized)
                InitializeViewModel();

            return Task.CompletedTask;
        }

        public Task OnNavigatedFromAsync() => Task.CompletedTask;

        private void InitializeViewModel()
        {
            var random = new Random();
            var colorCollection = new List<DataColor>();

            for (int i = 0; i < 8192; i++)
                colorCollection.Add(
                    new DataColor
                    {
                        Color = new SolidColorBrush(
                            Color.FromArgb(
                                200,
                                (byte)random.Next(0, 255),
                                (byte)random.Next(0, 255),
                                (byte)random.Next(0, 255)
                            )
                        )
                    }
                );

            Colors = colorCollection;

            _isInitialized = true;
        }
    }
}
