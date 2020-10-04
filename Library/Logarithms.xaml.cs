using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Classes;
using Library;

namespace Enginer_Calc
{
    /// <summary>
    /// Логика взаимодействия для Logarithms.xaml
    /// </summary>
    public partial class Logarithms : Window
    {
        public Logarithms()
        {
            InitializeComponent();
        }
        private void Log_a(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            String inputDataB = tbB.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                double dataB = Double.Parse(inputDataB);
                Log l = new Log(dataA, dataB);
                double result = l.log();

                resultat.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Log_10(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;
            try
            {
                double dataA = Double.Parse(inputDataA);
                Log l = new Log(dataA);
                double result = l.lg();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Log_e(object sender, RoutedEventArgs e)
        {
            String inputDataA = tbA.Text;

            try
            {
                double dataA = Double.Parse(inputDataA);
                Log l = new Log(dataA);
                double result = l.ln();

                resultat.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Numbers, Mayson, what are they meaning?..", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            Window main_window = new MainWindow();
            this.Hide();
            main_window.Show();
        }

        private void LanEng(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Result";
            ResultLabel.Width = 72;
            ResultLabel.Margin = new Thickness(524, 58, 0, 0);
            BodyLabel.Content = "Body";
            BaseLabel.Width = 52;
            BaseLabel.Margin = new Thickness(339, 55, 0, 0);
            BaseLabel.Content = "Base";
            LogCustomLabel.Content = "Logarithm custom base";
            LogELabel.Content = "Logarithm base Exp";
            Log10Label.Content = "Logarithm base 10";
            BackButton.Content = "Back";
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LanRus(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "Результат";
            ResultLabel.Width = 110;
            ResultLabel.Margin = new Thickness(516, 57, 0, 0);
            BodyLabel.Content = "Тело";
            BaseLabel.Width = 119;
            BaseLabel.Margin = new Thickness(306, 56, 0, 0);
            BaseLabel.Content = "Основание";
            LogCustomLabel.Content = "Логарифм с основанием";
            LogELabel.Content = "Логарифм с основанием Exp";
            Log10Label.Content = "Логарифм с основанием 10";
            BackButton.Content = "Назад";
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LanJap(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "結果";
            ResultLabel.Width = 52;
            ResultLabel.Margin = new Thickness(534, 58, 0, 0);
            BodyLabel.Content = "ボディ";
            BaseLabel.Width = 52;
            BaseLabel.Margin = new Thickness(339, 55, 0, 0);
            BaseLabel.Content = "底";
            LogCustomLabel.Content = "対数のカスタム底";
            LogELabel.Content = "対数の底Exp";
            Log10Label.Content = "対数の底１０";
            BackButton.Content = "戻る";
            MessageBox.Show("Language has been changed!", "Changing language", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
