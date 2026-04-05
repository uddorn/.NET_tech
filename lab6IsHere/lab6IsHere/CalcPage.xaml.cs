using System;
using System.Windows;
using System.Windows.Controls;

namespace lab6IsHere
{
    public partial class CalcPage : Page
    {
        public CalcPage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtLeg.Text);
                double angleDegrees = Convert.ToDouble(txtAngle.Text);

                if (angleDegrees <= 0 || angleDegrees >= 90)
                {
                    MessageBox.Show("Гострий кут має бути більшим за 0 і меншим за 90 градусів!", "Помилка вводу");
                    return;
                }
                if (a <= 0)
                {
                    MessageBox.Show("Катет має бути додатнім числом!", "Помилка вводу");
                    return;
                }

                double angleRadians = angleDegrees * Math.PI / 180.0;
                double b = a * Math.Tan(angleRadians);
                double c = a / Math.Cos(angleRadians);
                double area = 0.5 * a * b;
                double perimeter = a + b + c;

                txtResultArea.Text = $"Площа (S): {Math.Round(area, 2)}";
                txtResultPerimeter.Text = $"Периметр (P): {Math.Round(perimeter, 2)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.", "Помилка вводу");
            }
        }
        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}