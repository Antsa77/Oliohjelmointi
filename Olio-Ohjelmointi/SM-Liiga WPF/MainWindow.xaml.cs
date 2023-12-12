using JoukkueSovellus2;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Windows;

namespace JoukkueSovellus
{
    public partial class MainWindow : Window
    {
        private List<Joukkue> joukkueet;

        public MainWindow()
        {
            InitializeComponent();
            AlustaData();
        }

        private void AlustaData()
        {
            // Luo esimerkkidata
            joukkueet = new List<Joukkue>
            {
                new Joukkue
                {
                    Nimi = "HIFK",
                    Kotikaupunki = "Helsinki",
                    Pelaajat = new List<Pelaaja>
                    {
                        new Pelaaja { Etunimi = "Matti", Sukunimi = "Meikäläinen", PelaajaNumero = 10 },
                        new Pelaaja { Etunimi = "Pekka", Sukunimi = "Pelaaja", PelaajaNumero = 22 }
                    }
                },
                new Joukkue
                {
                    Nimi = "Jokerit",
                    Kotikaupunki = "Helsinki",
                    Pelaajat = new List<Pelaaja>
                    {
                        new Pelaaja { Etunimi = "Teppo", Sukunimi = "Testaaja", PelaajaNumero = 5 },
                        new Pelaaja { Etunimi = "Seppo", Sukunimi = "Selviytyjä", PelaajaNumero = 11 }
                    }
                }
            };

            // Päivitä DataGridit
            JoukkueetDataGrid.ItemsSource = joukkueet;
            PelaajatDataGrid.ItemsSource = joukkueet[0].Pelaajat;
        }

        private void TallennaJsonButtonClick(object sender, RoutedEventArgs e)
        {
            TallennaTiedosto("joukkueet.json", new DataContractJsonSerializer(typeof(List<Joukkue>)), joukkueet);
            MessageBox.Show("Joukkueet tallennettu JSON-tiedostoon.");
        }

        private void TallennaXmlButtonClick(object sender, RoutedEventArgs e)
        {
            TallennaTiedosto("joukkueet.xml", new DataContractSerializer(typeof(List<Joukkue>)), joukkueet);
            MessageBox.Show("Joukkueet tallennettu XML-tiedostoon.");
        }

        private void TallennaTiedosto(string tiedostoNimi, DataContractSerializer serializer, object data)
        {
            using (FileStream stream = new FileStream(tiedostoNimi, FileMode.Create))
            {
                serializer.WriteObject(stream, data);
            }
        }
    }
}