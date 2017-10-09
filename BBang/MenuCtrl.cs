using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp.UI.Animations;

namespace BBang
{
    public sealed partial class MainPage : Page
    {

        const double dCrownAnimationDuration = 700;

        private async void btnMenuHome_Click(object sender, RoutedEventArgs e)
        {
            await ImgCrown.Offset(offsetX: 0.0f, offsetY: 0.0f, duration: dCrownAnimationDuration, delay: 0).StartAsync();
        }

        private async void btnMenuBurger_Click(object sender, RoutedEventArgs e)
        {
            HamburgMenuToggleView(false);
            await ImgCrown.Offset(offsetX: 0.0f, offsetY: 85.0f, duration: dCrownAnimationDuration, delay: 0).StartAsync();
        }

        private async void btnMenuStore_Click(object sender, RoutedEventArgs e)
        {
            await ImgCrown.Offset(offsetX: 0.0f, offsetY: 180.0f, duration: dCrownAnimationDuration, delay: 0).StartAsync();
        }

        private async void btnMenuEvent_Click(object sender, RoutedEventArgs e)
        {
            await ImgCrown.Offset(offsetX: 0.0f, offsetY: 274.0f, duration: dCrownAnimationDuration, delay: 0).StartAsync();
        }

        private async void btnMenuDelivery_Click(object sender, RoutedEventArgs e)
        {
            await ImgCrown.Offset(offsetX: 0.0f, offsetY: 370.0f, duration: dCrownAnimationDuration, delay: 0).StartAsync();
        }
    }
}
