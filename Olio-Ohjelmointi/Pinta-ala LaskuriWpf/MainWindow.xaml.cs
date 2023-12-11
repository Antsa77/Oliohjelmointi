using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IkkunaLaskuri
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaskeButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(LeveysTextBox.Text, out double leveys) &&
                double.TryParse(KorkeusTextBox.Text, out double korkeus) &&
                double.TryParse(KarmiTextBox.Text, out double karmiLeveys))
            {
                double karminPiiri = 2 * (leveys + korkeus);

                double lasinPintaAla = (leveys - 2 * karmiLeveys) * (korkeus - 2 * karmiLeveys);

                double ikkunanPintaAla = leveys * korkeus;

                MessageBox.Show($"Karmin piiri: {karminPiiri} cm\nLasin pinta-ala: {lasinPintaAla:F2} cm^2\nIkkunan pinta-ala: {ikkunanPintaAla:F2} cm^2");

                PiirraIkkuna(leveys, korkeus, karmiLeveys);
            }
            else
            {
                MessageBox.Show("Syötä kelvolliset arvot leveydelle, korkeudelle ja karmipuun leveydelle.");
            }
        }

        private void PiirraIkkuna(double leveys, double korkeus, double karmiLeveys)
        {
            IkkunaCanvas.Children.Clear();

            Rectangle ikkuna = new Rectangle
            {
                Width = leveys,
                Height = korkeus,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(ikkuna, (IkkunaCanvas.Width - leveys) / 2);
            Canvas.SetTop(ikkuna, (IkkunaCanvas.Height - korkeus) / 2);
            IkkunaCanvas.Children.Add(ikkuna);

            Rectangle karmiYla = new Rectangle
            {
                Width = leveys,
                Height = karmiLeveys,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(karmiYla, (IkkunaCanvas.Width - leveys) / 2);
            Canvas.SetTop(karmiYla, (IkkunaCanvas.Height - korkeus) / 2 - karmiLeveys);
            IkkunaCanvas.Children.Add(karmiYla);

            Rectangle karmiAla = new Rectangle
            {
                Width = leveys,
                Height = karmiLeveys,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(karmiAla, (IkkunaCanvas.Width - leveys) / 2);
            Canvas.SetTop(karmiAla, (IkkunaCanvas.Height + korkeus) / 2);
            IkkunaCanvas.Children.Add(karmiAla);

            Rectangle karmiVasen = new Rectangle
            {
                Width = karmiLeveys,
                Height = korkeus - 2 * karmiLeveys,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(karmiVasen, (IkkunaCanvas.Width - leveys) / 2 - karmiLeveys);
            Canvas.SetTop(karmiVasen, (IkkunaCanvas.Height - korkeus) / 2);
            IkkunaCanvas.Children.Add(karmiVasen);

            Rectangle karmiOikea = new Rectangle
            {
                Width = karmiLeveys,
                Height = korkeus - 2 * karmiLeveys,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(karmiOikea, (IkkunaCanvas.Width + leveys) / 2);
            Canvas.SetTop(karmiOikea, (IkkunaCanvas.Height - korkeus) / 2);
            IkkunaCanvas.Children.Add(karmiOikea);
        }
    }
}
