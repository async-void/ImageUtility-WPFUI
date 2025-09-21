using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace ImageUtility.ViewModels.Pages
{
    public partial class RenameViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? _sourceDir;
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? _destinationDir;

        [RelayCommand(CanExecute = nameof(CanExecuteClear))]
        private async Task Clear()
        {
            SourceDir = null;
            DestinationDir = null;
        }

        [RelayCommand(CanExecute = nameof(CanExecuteApply))]
        private async Task Apply()
        {

        }

        [RelayCommand]
        private void OnSelectDir(string value)
        {
            var dialog = new OpenFolderDialog()
            {
                Title = "Select Folder",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Multiselect = false
            };
            if (dialog.ShowDialog() == true)
            {
                switch (value)
                {
                    case "source_dir":
                        SourceDir = dialog.FolderName;
                        break;
                    case "destination_dir":
                        DestinationDir = dialog.FolderName;
                        break;
                    default:
                        break;

                }
               
            }
        }

        public bool CanExecuteClear() => !string.IsNullOrEmpty(SourceDir) && !string.IsNullOrEmpty(DestinationDir);
        public bool CanExecuteApply() => !string.IsNullOrEmpty(SourceDir) && !string.IsNullOrEmpty(DestinationDir);
    }
}
