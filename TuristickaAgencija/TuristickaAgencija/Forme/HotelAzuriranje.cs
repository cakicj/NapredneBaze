using System;
using System.Linq;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class HotelAzuriranje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        private readonly HotelNeo4J hotelNeo4J;
        private readonly Hotel hotel;
        public HotelAzuriranje(HotelNeo4J hotelNeo4J, Hotel hotel)
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
            this.hotelNeo4J = hotelNeo4J;
            this.hotel = hotel;
        }

        private async void BtnAzurirajHotel_Click(object sender, EventArgs e)
        {
            hotelNeo4J.opis = tbOpis.Text;
            hotelNeo4J.komentari = tbKomentari.Text;
            hotelNeo4J.listaSlika = tbListaSlika.Text.Split(' ').ToList();
            hotelNeo4J.listaKodova = tbKodovi.Text;
            await dataProviderNeo4J.UpdateHotel(hotelNeo4J.ime, hotelNeo4J);

            hotel.UdaljenostOdPlaze = tbUdaljenostOdPlaze.Text;
            hotel.Ocena = tbOcena.Text;
            hotel.Zvezdice = tbZvezdice.Text;
            dataProviderCassandra.UpdateHotel(hotel);

            Close();
        }

        private void HotelAzuriranje_Load(object sender, EventArgs e)
        {
            tbIme.Text = hotelNeo4J.ime;
            tbDestinacija.Text = hotelNeo4J.Destinacija;
            tbOpis.Text = hotelNeo4J.opis;
            tbUdaljenostOdPlaze.Text = hotel.UdaljenostOdPlaze;
            tbOcena.Text = hotel.Ocena;
            tbZvezdice.Text = hotel.Zvezdice;
            tbKomentari.Text = hotelNeo4J.komentari;
            tbListaSlika.Text = "";
            foreach(string slika in hotelNeo4J.listaSlika)
            {
                tbListaSlika.Text += slika + " ";
            }
            tbVodici.Text = "";
            foreach(TuristickiVodicNeo4J vodic in hotelNeo4J.Vodici)
            {
                tbVodici.Text += vodic.ime + " " + vodic.prezime + " ";
            }
            tbKodovi.Text = hotelNeo4J.listaKodova;
        }
    }
}
