using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImageUtility.Components;
using Microsoft.Win32;
using System.Threading;
using Wpf.Ui;
using Wpf.Ui.Controls;
using Wpf.Ui.Extensions;

namespace ImageUtility.ViewModels.Pages
{
    public partial class RenameViewModel(IContentDialogService dialogService) : ObservableObject
    {

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? _sourceDir;
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        [NotifyCanExecuteChangedFor(nameof(ClearCommand))]
        private string? _destinationDir;
        [ObservableProperty]
        private string? _pattern;

        [ObservableProperty]
        private int _numberingValue;
        [ObservableProperty]
        private string? _extFilePath;

        [RelayCommand(CanExecute = nameof(CanExecuteClear))]
        private void Clear()
        {
            SourceDir = null;
            DestinationDir = null;
            Pattern = null;
            NumberingValue = 0;
        }

        [RelayCommand(CanExecute = nameof(CanExecuteApply))]
        private async Task Apply()
        {
            await dialogService.ShowSimpleDialogAsync(
                   new SimpleContentDialogCreateOptions
                   {
                      Title = "File Renamer",
                      Content = "Renaming Files...",
                      PrimaryButtonText = "Save",
                      CloseButtonText = "Cancel"
                   }, new CancellationToken());
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

        [RelayCommand]
        private void OnLoadTextFile()
        {
            var dialog = new OpenFileDialog()
            {
                Title = "Select File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "txt files (*.txt)|*.txt",
            };
            if (!dialog.ShowDialog() == true)
            {
                ExtFilePath = dialog.FileName;
            }
        }

        public bool CanExecuteClear() => !string.IsNullOrEmpty(SourceDir) && !string.IsNullOrEmpty(DestinationDir);
        public bool CanExecuteApply() => !string.IsNullOrEmpty(SourceDir) && !string.IsNullOrEmpty(DestinationDir);
    }
}
