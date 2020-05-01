/* Author: Theodore Pollock
 * Email: PollockT@TulsaPretech.com
 * File Name: Calculator.xamal.cs
 */

using System;
using System.Windows;
using System.Windows.Controls;

namespace Caluclator
{  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            textEqu.Text += button.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }

            #pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception)
            {
                textEqu.Text = "Error!";
            }
            #pragma warning restore CA1031 // Do not catch general exception types

        }

        private void Result()
        {
            string operation;
            int magicZero = 0;
            if (textEqu.Text.Contains("+"))
            {
                magicZero = textEqu.Text.IndexOf("+");
            }
            else if (textEqu.Text.Contains("-"))
            {
                magicZero = textEqu.Text.IndexOf("-");
            }
            else if (textEqu.Text.Contains("*"))
            {
                magicZero = textEqu.Text.IndexOf("*");
            }
            else if (textEqu.Text.Contains("/"))
            {
                magicZero = textEqu.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            operation = textEqu.Text.Substring(magicZero, 1);
            double variable1 = Convert.ToDouble(textEqu.Text.Substring(0, magicZero));
            double variable2 = Convert.ToDouble(textEqu.Text.Substring(magicZero + 1, textEqu.Text.Length - magicZero - 1));

            if (operation == "+")
            {
                textEqu.Text += "=" + (variable1 + variable2);
            }
            else if (operation == "-")
            {
                textEqu.Text += "=" + (variable1 - variable2);
            }
            else if (operation == "*")
            {
                textEqu.Text += "=" + (variable1 * variable2);
            }
            else
            {
                textEqu.Text += "=" + (variable1 / variable2);
            }
        }

        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            textEqu.Text = "";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (textEqu.Text.Length > 0)
            {
                textEqu.Text = textEqu.Text.Substring(0, textEqu.Text.Length - 1);
            }
        }

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.Show();                    
        }
    }
}
