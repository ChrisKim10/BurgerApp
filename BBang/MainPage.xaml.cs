using BBang.Model;
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
        private bool isFirstRun = false; //그룹리스트가 selectedIndex = 0 으로 시작되어 초기화면을 제어하기 위해

        public DataModel BurgerDataModel { get; }

        public MainPage()
        {
            this.InitializeComponent();
            tbCompanyInfo.Text = Common.CompanyInfoText;

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

        private void gridViewBurger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = gvBurger.SelectedIndex;

            if (index == -1)
                return;

            if (!isFirstRun)
            {
                //이상하네 원래 -1로 시작되어야 하는데
                gvBurger.SelectedIndex = -1;
                isFirstRun = true;
                return;
            }

            Burger burger = ((GridView)sender).SelectedItem as Burger;

            gridDetailView.DataContext = burger;
            NutrientControl.SetData(burger.NutrientInfo);

            HamburgMenuToggleView(true);

            gvBurger.SelectedIndex = -1;
        }

        private void HamburgMenuToggleView(bool isDetail)
        {
            if(isDetail)
            {
                gridGroupView.Visibility = Visibility.Collapsed;
                gridDetailView.Visibility = Visibility.Visible;
            }
            else
            {
                gridDetailView.Visibility = Visibility.Collapsed;
                gridGroupView.Visibility = Visibility.Visible;
            }
        }
    }
}
