/* Author: Theodore Pollock
 * Email: PollockT@TulsaPretech.com
 * File Name: Converter.xamal.cs
 */

using System;
using System.Windows;

namespace Caluclator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(rdCel.IsChecked == true)
                {
                    double celcius = Convert.ToDouble(txtCel.Text);
                    txtFah.Text = Convert.ToString((celcius * 1.8) + 32);
                }
                if(rdFah.IsChecked == true)
                {
                    double fahrenheit = Convert.ToDouble(txtFah.Text);
                    txtCel.Text = Convert.ToString((fahrenheit - 32) / 1.8);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter a Number");
            }
        }
    }
}
