﻿using ImageUtility.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageUtility.Views.Pages
{
    /// <summary>
    /// Interaction logic for RenamePage.xaml
    /// </summary>
    public partial class RenamePage : Page
    {
        public RenameViewModel ViewModel { get; }
        public RenamePage(RenameViewModel vm)
        {
            ViewModel = vm;
            InitializeComponent();
        }
    }
}
