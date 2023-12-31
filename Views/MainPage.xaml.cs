﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TodoXaml.Models;
using TodoXaml.Views;
using TodoXaml.ViewModels;

namespace TodoXaml
{
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {

            this.InitializeComponent();
            DataContext = new MainPageViewModel();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TodoDetailsPage), null);
        }

        private void Todos_OnItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(TodoDetailsPage), e.ClickedItem);
        }
    }
    class ViewModel
    {

    }
}
