using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation; 

namespace lab6IsHere
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGoToCalc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CalcPage.xaml", UriKind.Relative));
        }
    }
}