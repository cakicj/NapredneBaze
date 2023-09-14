using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class TuristickaAgencijaPrikaz : Form
    {
        private readonly DataProviderNeo4J Neo4Jprovider;
        private readonly DataProviderCassandra CassandraProvider;
        public TuristickaAgencijaPrikaz()
        {
            InitializeComponent();
            Neo4Jprovider = new DataProviderNeo4J();
            CassandraProvider = new DataProviderCassandra();
        }
        private async void TuristickaAgencijaForma_Load(object sender, EventArgs e)
        {
            TuristickaAgencijaNeo4J agencija = await Neo4Jprovider.GetAgencija();
            tbOpis.Text = agencija.opis;
            tbFilijale.Text = agencija.listaFilijala;
            lblTelefon.Text = "Br. telefona: " + agencija.kontaktTel;
            lblRadnoVreme.Text = "Radno vreme: " + agencija.radnoVreme;
            lblVlasnik.Text = "Vlasnik: " + agencija.vlasnik;
            lblSediste.Text = "Sediste: " + agencija.sediste;
            lblCekovi.Text = "Prihvata cekove? " + agencija.cekovi;
            lblRate.Text = "Placanje na rate? " + agencija.rate;
            foreach(DrzavaNeo4J drzavaNeo4J in agencija.Drzave)
            {
                Drzava drzava = CassandraProvider.GetDrzava(drzavaNeo4J.ime);
                if (drzava.ImaMore == "da")
                {
                    lbDrzaveSaMorem.Items.Add(drzava.Ime);
                }
                else
                {
                    lbDrzaveBezMora.Items.Add(drzava.Ime);
                }
            }
        }

        private void BtnIzaberiDrzavu_Click(object sender, EventArgs e)
        {
            if (lbDrzaveBezMora.SelectedItem != null && lbDrzaveSaMorem.SelectedItem != null)
            {
                lbDrzaveSaMorem.ClearSelected();
                lbDrzaveBezMora.ClearSelected();
                MessageBox.Show("Izaberite jednu drzavu");
            }
            else if (lbDrzaveSaMorem.SelectedItem != null)
            {
                string ime = lbDrzaveSaMorem.SelectedItem.ToString();
                lbDrzaveSaMorem.ClearSelected();
                DrzavaPrikaz drzava = new DrzavaPrikaz(ime);
                drzava.Show();
            }
            else if (lbDrzaveBezMora.SelectedItem != null)
            {
                string ime = lbDrzaveBezMora.SelectedItem.ToString();
                lbDrzaveBezMora.ClearSelected();
                DrzavaPrikaz drzava = new DrzavaPrikaz(ime);
                drzava.Show();
            }
            else
            {
                MessageBox.Show("Izaberite drzavu");
            }
        }

        private void BtnDodajDrzavu_Click(object sender, EventArgs e)
        {
            DrzavaDodavanje dodajDrzavu = new DrzavaDodavanje();
            dodajDrzavu.Show();
        }

        private async void BtnObrisiDrzavu_Click(object sender, EventArgs e)
        {
            if (lbDrzaveBezMora.SelectedItem != null && lbDrzaveSaMorem.SelectedItem != null)
            {
                lbDrzaveSaMorem.ClearSelected();
                lbDrzaveBezMora.ClearSelected();
                MessageBox.Show("Izaberite jednu drzavu");
            }
            else if (lbDrzaveBezMora.SelectedItem != null)
            {
                string ime = lbDrzaveBezMora.SelectedItem.ToString();
                lbDrzaveBezMora.ClearSelected();
                await Neo4Jprovider.DeleteDrzava(ime);
                CassandraProvider.DeleteDrzava(ime);
            }
            else if (lbDrzaveSaMorem.SelectedItem != null)
            {
                string ime = lbDrzaveSaMorem.SelectedItem.ToString();
                lbDrzaveSaMorem.ClearSelected();
                await Neo4Jprovider.DeleteDrzava(ime);
                CassandraProvider.DeleteDrzava(ime);
            }
            else
            {
                MessageBox.Show("Izaberite drzavu");
            }
        }

      
    }
}
