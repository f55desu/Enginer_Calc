using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
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
                MessageBox.Show("Ты числа-то введи,ばか！");
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
                MessageBox.Show("Ты числа-то введи,ばか！");
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
                MessageBox.Show("Ты числа-то введи,ばか！");
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
                MessageBox.Show("Ты числа-то введи,ばか！");
            }
        }

        private void GoToLog(object sender, RoutedEventArgs e)
        {
            Window logs_window = new Logarithms();
            Window main_window = new MainWindow();
            main_window.Close();
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
                MessageBox.Show("Ты числа-то введи,ばか！");
            }
        }
    }
}
