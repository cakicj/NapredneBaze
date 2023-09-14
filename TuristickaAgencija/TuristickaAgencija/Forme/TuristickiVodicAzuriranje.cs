using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class TuristickiVodicAzuriranje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        private readonly TuristickiVodicNeo4J turistickiVodicNeo4J;
        private readonly TuristickiVodic turistickiVodic;
        public TuristickiVodicAzuriranje(TuristickiVodicNeo4J turistickiVodicNeo4J, TuristickiVodic turistickiVodic)
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
            this.turistickiVodicNeo4J = turistickiVodicNeo4J;
            this.turistickiVodic = turistickiVodic;
        }

        private async void BtnAzurirajVodica_Click(object sender, EventArgs e)
        {
            turistickiVodicNeo4J.govori = tbJezici.Text;
            turistickiVodicNeo4J.uTurizmu = tbUTurizmu.Text;
            await dataProviderNeo4J.UpdateVodic(turistickiVodicNeo4J.ime, turistickiVodicNeo4J.prezime, turistickiVodicNeo4J);

            turistickiVodic.NaDestinaciji = tbNaDestinaciji.Text;
            dataProviderCassandra.UpdateVodic(turistickiVodic);

            Close();
        }

        private void TuristickiVodicAzuriranje_Load(object sender, EventArgs e)
        {
            tbIme.Text = turistickiVodicNeo4J.ime;
            tbPrezime.Text = turistickiVodicNeo4J.prezime;
            tbJezici.Text = turistickiVodicNeo4J.govori;
            tbUTurizmu.Text = turistickiVodicNeo4J.uTurizmu;
            tbNaDestinaciji.Text = turistickiVodic.NaDestinaciji;
        }
    }
}
