using System;
using System.Linq;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class DestinacijaAzuriranje : Form
    {
        private readonly DestinacijaNeo4J destinacijaNeo4J;
        private readonly Destinacija destinacija;
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public DestinacijaAzuriranje(DestinacijaNeo4J destinacijaNeo4J, Destinacija destinacija)
        {
            InitializeComponent();
            this.destinacijaNeo4J = destinacijaNeo4J;
            this.destinacija = destinacija;
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void BtnAzurirajDestinaciju_Click(object sender, EventArgs e)
        {
            destinacijaNeo4J.opis = tbOpis.Text;
            destinacijaNeo4J.imaMore = rbDa.Checked ? rbDa.Text : rbNe.Text;
            destinacijaNeo4J.duzinaPlaze = tbDuzinaPlaze.Text;
            destinacijaNeo4J.listaSlika = tbListaSlika.Text.Split(' ').ToList();
            if (rbDa.Checked)
            {
                destinacijaNeo4J.imaMore = "Da";
            }
            else
            {
                destinacijaNeo4J.imaMore = "Ne";
            }
            await dataProviderNeo4J.UpdateDestinacija(destinacijaNeo4J.ime, destinacijaNeo4J);

            destinacija.BrStanovnika = tbBrStanovnika.Text;
            dataProviderCassandra.UpdateDestinacija(destinacija);

            this.Close();
        }

        private void DestinacijaAzuriranje_Load(object sender, EventArgs e)
        {
            tbIme.Text = destinacijaNeo4J.ime;
            tbDrzava.Text = destinacijaNeo4J.Drzava;
            tbOpis.Text = destinacijaNeo4J.opis;
            tbBrStanovnika.Text = destinacija.BrStanovnika;
            if (destinacijaNeo4J.imaMore == "Da")
            {
                rbDa.Checked = true;
                rbNe.Checked = false;
            }
            else
            {
                rbDa.Checked = false;
                rbNe.Checked = true;
            }
            tbDuzinaPlaze.Text = destinacijaNeo4J.duzinaPlaze;
            tbDuzinaPlaze.Text = "";
            foreach (HotelNeo4J hotel in destinacijaNeo4J.Hoteli)
            {
                tbDuzinaPlaze.Text += hotel.ime + ", ";
            }
            tbListaSlika.Text = "";
            foreach (string slika in destinacijaNeo4J.listaSlika)
            {
                tbListaSlika.Text += slika + ", ";
            }
        }
    }
}
