using System.Windows;
using System.Windows.Controls;

namespace WpfOstoskarry
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OstaButtonClick(object sender, RoutedEventArgs e)
        {
            TyhjennaOstoskarry();
        }

        private void TyhjennaOstoskarry()
        {
            // Käydään läpi kaikki StackPanelin lapset (TextBlockit) ja asetetaan CheckBoxit unchecked-tilaan
            foreach (UIElement element in StockPanel.Children)
            {
                if (element is TextBlock)
                {
                    // Poista tuote ostoskorista
                    StockPanel.Children.Remove(element);
                    break;
                }
            }

            // Aseta kaikki CheckBoxit unchecked-tilaan
            CheckBoxTuote1.IsChecked = false;
            CheckBoxTuote2.IsChecked = false;
            CheckBoxTuote3.IsChecked = false;
            CheckBoxTuote4.IsChecked = false;
            CheckBoxTuote5.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                // Luo uusi TextBlock ja lisää se StackPaneliin, kun CheckBox on valittu
                if (checkBox.IsChecked == true)
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = checkBox.Content.ToString();
                    StockPanel.Children.Add(textBlock);
                }
            }
        }
    }
}
