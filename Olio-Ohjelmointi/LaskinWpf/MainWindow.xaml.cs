using System;
using System.Windows;

namespace WpfLaskin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SummaButtonClick(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Summa);
        }

        private void ErotusButtonClick(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Erotus);
        }

        private void KertolaskuButtonClick(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Kertolasku);
        }

        private void JakolaskuButtonClick(object sender, RoutedEventArgs e)
        {
            LaskeJaNaytaTulos(Laskin.Jakolasku);
        }

        private void LaskeJaNaytaTulos(Func<double, double, double> laskutoimitus)
        {
            try
            {
                double luku1 = Convert.ToDouble(Luku1TextBox.Text);
                double luku2 = Convert.ToDouble(Luku2TextBox.Text);

                double tulos = laskutoimitus(luku1, luku2);

                TulosTextBlock.Text = $"Tulos: {tulos}";
            }
            catch (Exception ex)
            {
                TulosTextBlock.Text = $"Virhe: {ex.Message}";
            }
        }
    }

    public static class Laskin
    {
        public static double Summa(double a, double b)
        {
            return a + b;
        }

        public static double Erotus(double a, double b)
        {
            return a - b;
        }

        public static double Kertolasku(double a, double b)
        {
            return a * b;
        }

        public static double Jakolasku(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                throw new ArgumentException("Jakolasku nollalla ei ole määriteltyä arvoa.");
        }
    }
}
