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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace BBang
{
    public sealed partial class SubMenu : UserControl
    {
        public Menu menu = new Menu();

        public SubMenu()
        {
            this.InitializeComponent();

            InitButton();


        }

        public void InitButton()
        {
            MainMenu.DataContext = menu.listLeftMenu[0];
            btnMenu1.DataContext = menu.listLeftMenu[1];
            btnMenu2.DataContext = menu.listLeftMenu[2];
            btnMenu3.DataContext = menu.listLeftMenu[3];
        }
    }
}
