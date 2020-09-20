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
                MessageBox.Show("Ты числа-то введи,ばか！");
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
                MessageBox.Show("Ты числа-то введи,ばか！");
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
                MessageBox.Show("Ты числа-то введи,ばか！");
            }

        }
    }
}
