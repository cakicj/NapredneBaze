using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class TuristickiVodicDodavanje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public TuristickiVodicDodavanje()
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void BtnDodajVodica_Click(object sender, EventArgs e)
        {
            TuristickiVodicNeo4J vodicNeo4J = new TuristickiVodicNeo4J
            {
                ime = tbIme.Text,
                prezime = tbPrezime.Text,
                uTurizmu = tbUTurizmu.Text,
                govori = tbJezici.Text
            };
            await dataProviderNeo4J.AddVodic(vodicNeo4J);

            TuristickiVodic vodic = new TuristickiVodic
            {
                Ime = tbIme.Text,
                Prezime = tbPrezime.Text,
                NaDestinaciji = tbNaDestinaciji.Text
            };
            dataProviderCassandra.AddVodic(vodic);
        }
    }
}
