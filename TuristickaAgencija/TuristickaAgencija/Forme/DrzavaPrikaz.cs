using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class DrzavaPrikaz : Form
    {
        private readonly string ime;
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public DrzavaPrikaz(string ime)
        {
            InitializeComponent();
            this.ime = ime;
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void DrzavaForma_Load(object sender, EventArgs e)
        {
            DrzavaNeo4J drzavaNeo4J = await dataProviderNeo4J.GetDrzava(ime);
            Drzava drzava = dataProviderCassandra.GetDrzava(ime);
            lblDrzava.Text = drzavaNeo4J.ime;
            lblGlavniGrad.Text = drzavaNeo4J.glavniGrad;
            lblIzlazNaMore.Text = "Ima more: " + drzava.ImaMore;
            tbOpis.Text = drzavaNeo4J.opis;
            foreach(DestinacijaNeo4J destinacija in drzavaNeo4J.Destinacije)
            {
                lbDestinacije.Items.Add(destinacija.ime);
            }
        }

        private void BtnDestinacija_Click(object sender, EventArgs e)
        {
            if (lbDestinacije.SelectedItem != null)
            {
                string ime = lbDestinacije.SelectedItem.ToString();
                lbDestinacije.ClearSelected();
                DestinacijaPrikaz destinacija = new DestinacijaPrikaz(ime);
                destinacija.Show();
            }
            else
            {
                MessageBox.Show("Izaberite destinaciju");
            }
        }

        private void BtnDodajDestinaciju_Click(object sender, EventArgs e)
        {
            DestinacijaDodavanje dodajDestinaciju = new DestinacijaDodavanje();
            dodajDestinaciju.Show();
        }

        private async void BtnObrisiDestinaciju_Click(object sender, EventArgs e)
        {
            if (lbDestinacije.SelectedItem != null)
            {
                string ime = lbDestinacije.SelectedItem.ToString();
                lbDestinacije.ClearSelected();
                await dataProviderNeo4J.DeleteDestinacija(ime);
                dataProviderCassandra.DeleteDestinacija(ime);
            }
            else
            {
                MessageBox.Show("Izaberite destinaciju");
            }
        }

        private async void BtnAzurirajDrzavu_Click(object sender, EventArgs e)
        {
            DrzavaAzuriranje drzava = new DrzavaAzuriranje(await dataProviderNeo4J.GetDrzava(ime), dataProviderCassandra.GetDrzava(ime));
            drzava.Show();
        }
    }
}
