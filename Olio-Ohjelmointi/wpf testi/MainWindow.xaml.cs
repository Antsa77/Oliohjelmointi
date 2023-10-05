using System.Windows;
namespace WpfCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            double input1 = double.Parse(Input1.Text);
            double input2 = double.Parse(Input2.Text);
            double result = Laskin.Summa(input1, input2);
            ResultText.Text = result.ToString();
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            double input1 = double.Parse(Input1.Text);
            double input2 = double.Parse(Input2.Text);
            double result = Laskin.Erotus(input1, input2);
            ResultText.Text = result.ToString();
        }
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double input1 = double.Parse(Input1.Text);
            double input2 = double.Parse(Input2.Text);
            double result = Laskin.Kertolasku(input1, input2);
            ResultText.Text = result.ToString();
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            double input1 = double.Parse(Input1.Text);
            double input2 = double.Parse(Input2.Text);
            double result = Laskin.Jakolasku(input1, input2);
            ResultText.Text = result.ToString();
        }
    }
}