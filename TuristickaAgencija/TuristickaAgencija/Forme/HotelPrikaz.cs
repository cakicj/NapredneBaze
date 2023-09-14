using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class HotelPrikaz : Form
    {
        private readonly string ime;
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public HotelPrikaz(string ime)
        {
            InitializeComponent();
            this.ime = ime;
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void HotelPrikaz_Load(object sender, EventArgs e)
        {
            HotelNeo4J hotelNeo4J = await dataProviderNeo4J.GetHotel(ime);
            Hotel hotel = dataProviderCassandra.GetHotel(ime);
            lblHotel.Text = hotelNeo4J.ime;
            lblDestinacija.Text = hotelNeo4J.Destinacija;
            lblUdaljenostOdPlaze.Text = hotel.UdaljenostOdPlaze;
            lblOcena.Text = hotel.Ocena;
            lblZvezdice.Text = hotel.Zvezdice;
            tbOpis.Text = hotelNeo4J.opis;
            tbKomentari.Text = hotelNeo4J.komentari;
            tbKodovi.Text = hotelNeo4J.listaKodova;
            foreach (TuristickiVodicNeo4J vodic in hotelNeo4J.Vodici)
            {
                string imeVodica = vodic.ime + " " + vodic.prezime;
                lbVodici.Items.Add(imeVodica);
            }
        }

        private void BtnIzaberiVodica_Click(object sender, EventArgs e)
        {
            if (lbVodici.SelectedItem != null)
            {
                string ime = lbVodici.SelectedItem.ToString();
                lbVodici.ClearSelected();
                TuristickiVodicPrikaz vodic = new TuristickiVodicPrikaz(ime);
                vodic.Show();
            }
            else
            {
                MessageBox.Show("Izaberite vodica");
            }
        }

        private void BtnDodajVodica_Click(object sender, EventArgs e)
        {
            TuristickiVodicDodavanje dodajVodica = new TuristickiVodicDodavanje();
            dodajVodica.Show();
        }

        private async void BtnIzbrisiVodica_Click(object sender, EventArgs e)
        {
            if (lbVodici.SelectedItem != null)
            {
                string[] ime = lbVodici.SelectedItem.ToString().Split(' ');
                lbVodici.ClearSelected();
                await dataProviderNeo4J.DeleteVodic(ime[0], ime[1]);
                dataProviderCassandra.DeleteVodic(ime[0], ime[1]);
            }
            else
            {
                MessageBox.Show("Izaberite vodica");
            }
        }

        private async void BtnAzurirajHotel_Click(object sender, EventArgs e)
        {
            HotelAzuriranje hotel = new HotelAzuriranje(await dataProviderNeo4J.GetHotel(ime), dataProviderCassandra.GetHotel(ime));
            hotel.Show();
        }
    }
}
