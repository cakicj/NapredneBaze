using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class DestinacijaPrikaz : Form
    {
        private readonly string ime;
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public DestinacijaPrikaz(string ime)
        {
            InitializeComponent(); 
            this.ime = ime;
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void DestinacijaPrikaz_Load(object sender, EventArgs e)
        {
            DestinacijaNeo4J destinacijaNeo4J = await dataProviderNeo4J.GetDestinacija(ime);
            Destinacija destinacija = dataProviderCassandra.GetDestinacija(ime);
            lblDestinacija.Text = destinacijaNeo4J.ime;
            lblBrStanovnika.Text = destinacija.BrStanovnika;
            lblDuzinaPlaze.Text = destinacijaNeo4J.duzinaPlaze;
            lblDrzava.Text = destinacijaNeo4J.Drzava;
            lblMore.Text = "Ima more: " + destinacijaNeo4J.imaMore;
            tbOpis.Text = destinacijaNeo4J.opis;
            foreach (HotelNeo4J hotel in destinacijaNeo4J.Hoteli)
            {
                lbHoteli.Items.Add(hotel.ime);
            }
        }

        private void BtnIzaberiHotel_Click(object sender, EventArgs e)
        {
            if (lbHoteli.SelectedItem != null)
            {
                string ime = lbHoteli.SelectedItem.ToString();
                lbHoteli.ClearSelected();
                HotelPrikaz destinacija = new HotelPrikaz(ime);
                destinacija.Show();
            }
            else
            {
                MessageBox.Show("Izaberite hotel");
            }
        }

        private void BtnDodajHotel_Click(object sender, EventArgs e)
        {
            HotelDodavanje dodajHotel = new HotelDodavanje();
            dodajHotel.Show();
        }

        private async void BtnIzbrisiHotel_Click(object sender, EventArgs e)
        {
            if (lbHoteli.SelectedItem != null)
            {
                string ime = lbHoteli.SelectedItem.ToString();
                lbHoteli.ClearSelected();
                await dataProviderNeo4J.DeleteHotel(ime);
                dataProviderCassandra.DeleteHotel(ime);
            }
            else
            {
                MessageBox.Show("Izaberite hotel");
            }
        }

        private async void BtnAzurirajDestinaciju_Click(object sender, EventArgs e)
        {
            DestinacijaAzuriranje destinacijaAzuriranje = new DestinacijaAzuriranje(await dataProviderNeo4J.GetDestinacija(ime), dataProviderCassandra.GetDestinacija(ime));
            destinacijaAzuriranje.Show();
        }
    }
}
