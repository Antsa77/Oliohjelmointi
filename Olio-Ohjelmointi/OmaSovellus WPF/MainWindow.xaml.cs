using System.Collections.ObjectModel;
using System.Windows;

namespace OmaSovellus_WPF
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 1, Name = "Tuote 1", Price = 19.99 },
                new Product { Id = 2, Name = "Tuote 2", Price = 29.99 },
                new Product { Id = 3, Name = "Tuote 3", Price = 39.99 }
            };
            lvProducts.ItemsSource = Products;
        }

        private void lvProducts_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lvProducts.SelectedItem != null)
            {
                Product selectedProduct = lvProducts.SelectedItem as Product;
                MessageBox.Show($"Valittu tuote: {selectedProduct.Name}, Hinta: {selectedProduct.Price:C}");
            }
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Products.Add(new Product { Id = Products.Count + 1, Name = "Uusi tuote", Price = 0.0 });
        }

        private void btnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lvProducts.SelectedItem != null)
            {
                Product selectedProduct = lvProducts.SelectedItem as Product;
                Products.Remove(selectedProduct);
            }
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}