using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class HotelDodavanje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public HotelDodavanje()
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void BtnDodajHotel_Click(object sender, EventArgs e)
        {
            HotelNeo4J hotelNeo4J = new HotelNeo4J
            {
                ime = tbIme.Text,
                Destinacija = tbDestinacija.Text,
                opis = tbOpis.Text,
                komentari = tbKomentari.Text,
                listaKodova = tbKodovi.Text,
                listaSlika = tbListaSlika.Text.Split(' ').ToList()
            };
            string[] vodici = tbVodici.Text.Split(' ');
            hotelNeo4J.Vodici = new List<TuristickiVodicNeo4J>();
            for(int i = 0; i < vodici.Length; i += 2)
            {
                string ime = vodici[i], prezime = vodici[i + 1];
                hotelNeo4J.Vodici.Add(await dataProviderNeo4J.GetVodic(ime, prezime));
            }
            await dataProviderNeo4J.AddHotel(hotelNeo4J);

            Hotel hotel = new Hotel
            {
                Ime = tbIme.Text,
                Zvezdice = tbZvezdice.Text,
                UdaljenostOdPlaze = tbUdaljenostOdPlaze.Text,
                Ocena = tbOcena.Text
            };
            dataProviderCassandra.AddHotel(hotel);
        }
    }
}
