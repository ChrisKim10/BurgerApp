﻿using BBang.Model;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BBang
{
    public sealed partial class MainPage : Page
    {
        public DataModel BurgerDataModel { get; }

        public MainPage()
        {
            this.InitializeComponent();

            BurgerDataModel = new DataModel();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            InitBurgerData();
        }

        public void InitBurgerData()
        {
            BurgerDataModel.GetBurgersGrouped();

            if (BurgerDataModel.IsDataLoaded)
            {
                BurgerCVS.Source = BurgerDataModel.groups;
            }
        }

        private void lstWhopper_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
