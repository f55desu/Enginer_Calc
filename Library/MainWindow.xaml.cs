using System;
using System.Collections.Generic;
using System.Globalization;
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
using Classes;
using Enginer_Calc;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language;
        public MainWindow()
        {
            InitializeComponent();
            language = "en-US";
        }
        private void Summ(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Sum s = new Sum(dataA, dataB);
                double result = s.Summary();

                resultat.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?.." , "Error" , MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Difference(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Sum s = new Sum(dataA, dataB);
                double result = s.Difference();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Sum s = new Sum(dataA, dataB);
                double result = s.Multiply();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Sum s = new Sum(dataA, dataB);
                double result = s.Division();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GoToLog(object sender, RoutedEventArgs e)
        {
            Window logs_window = new Logarithms();
            this.Hide();
            logs_window.Show();
        }

        private void Sukurt(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                Others s = new Others(dataA);
                double result = s.Sqrt();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Power(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Others s = new Others(dataA, dataB);
                double result = s.Power();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Sin(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.Sin();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Cos(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.Cos();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Tan(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.Tan();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Ctg(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.Ctg();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ArcSin(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.ArcSin();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ArcCos(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.ArcCos();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void ArcTan(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Trigonometry s = new Trigonometry(dataA);
                double result = s.ArcTan();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Power_of_10(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Others s = new Others(dataA, dataB);
                double result = s.Power_of_10();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LanEng(object sender, RoutedEventArgs e)
        {
            //ResultLabel.Margin = new Thickness(519, 32, 0, 0);
            //ResultLabel.Width = 70;
            
            language = "en-US";
            CultureInfo lang = new CultureInfo(language);
            App.Language = lang;
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void LanRus(object sender, RoutedEventArgs e)
        {
            //ResultLabel.Margin = new Thickness(508, 32, 0, 0);
            //ResultLabel.Width = 110;
            
            language = "ru-RU";
            CultureInfo lang = new CultureInfo(language);
            App.Language = lang;
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void LanJap(object sender, RoutedEventArgs e)
        {
            //ResultLabel.Margin = new Thickness(519, 32, 0, 0);
            //ResultLabel.Width = 70;
            
            language = "ja-JP";
            CultureInfo lang = new CultureInfo(language);
            App.Language = lang;
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_ResetX_Click(object sender, RoutedEventArgs e)
        {
            tbA.Text = "";
        }

        private void Button_ResetY_Click(object sender, RoutedEventArgs e)
        {
            tbB.Text = "";
        }
    }
}