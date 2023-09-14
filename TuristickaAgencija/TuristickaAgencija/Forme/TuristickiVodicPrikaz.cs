using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class TuristickiVodicPrikaz : Form
    {
        private readonly string ime;
        private readonly string prezime;
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public TuristickiVodicPrikaz(string ime)
        {
            InitializeComponent();
            this.ime = ime.Split(' ')[0];
            this.prezime = ime.Split(' ')[1];
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void TuristickiVodicPrikaz_Load(object sender, EventArgs e)
        {
            TuristickiVodicNeo4J vodicNeo4J = await dataProviderNeo4J.GetVodic(ime, prezime);
            TuristickiVodic vodic = dataProviderCassandra.GetVodic(ime, prezime);
            lblIme.Text = vodicNeo4J.ime;
            lblUTurizmu.Text = vodicNeo4J.uTurizmu;
            lblNaDestinaciji.Text = vodic.NaDestinaciji;
            tbJezici.Text = vodicNeo4J.govori;
        }

        private async void btnAzurirajVodica_Click(object sender, EventArgs e)
        {
            TuristickiVodicAzuriranje vodic = new TuristickiVodicAzuriranje(await dataProviderNeo4J.GetVodic(ime, prezime), dataProviderCassandra.GetVodic(ime, prezime));
            vodic.Show();
        }
    }
}
