using System.Windows;

namespace TaloWpf
{
    public partial class MainWindow : Window
    {
        private float lampotila;
        private bool keittioValot;
        private bool olohuoneenValot;
        private bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();

            lampotila = 20.0f;
            keittioValot = false;
            olohuoneenValot = false;
            oviLukossa = false;
        }

        private void ValotButtonClick(object sender, RoutedEventArgs e)
        {
            keittioValot = !keittioValot;
            olohuoneenValot = !olohuoneenValot;

        }

        private void LampotilaSliderValueChanged(object sender, RoutedEventArgs e)
        {
            lampotila = (float)LampotilaSlider.Value;

        }

        private void OviButtonClick(object sender, RoutedEventArgs e)
        {
            oviLukossa = !oviLukossa;
        }
    }
}
