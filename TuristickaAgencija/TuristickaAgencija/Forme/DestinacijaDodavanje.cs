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
    public partial class DestinacijaDodavanje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public DestinacijaDodavanje()
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void BtnDodajDestinaciju_Click(object sender, EventArgs e)
        {
            DestinacijaNeo4J destinacijaNeo4J = new DestinacijaNeo4J
            {
                ime = tbIme.Text,
                Drzava = tbDrzava.Text,
                opis = tbOpis.Text,
                imaMore = rbDa.Checked ? rbDa.Text : rbNe.Text,
                duzinaPlaze = rbDa.Checked ? tbDuzinaPlaze.Text : "0"
            };
            string[] hoteli = tbHoteli.Text.Split(' ');
            destinacijaNeo4J.Hoteli = new List<HotelNeo4J>();
            foreach(string imeHotela in hoteli)
            {
                destinacijaNeo4J.Hoteli.Add(await dataProviderNeo4J.GetHotel(imeHotela));
            }
            destinacijaNeo4J.listaSlika = tbListaSlika.Text.Split(' ').ToList();
            await dataProviderNeo4J.AddDestinacija(destinacijaNeo4J);

            Destinacija destinacija = new Destinacija
            {
                Ime = tbIme.Text,
                BrStanovnika = tbBrStanovnika.Text
            };
            dataProviderCassandra.AddDestinacija(destinacija);

            this.Close();
        }
    }
}
