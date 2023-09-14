using System;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class DrzavaAzuriranje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        private readonly DrzavaNeo4J drzavaNeo4J;
        private readonly Drzava drzava;
        public DrzavaAzuriranje(DrzavaNeo4J drzavaNeo4J, Drzava drzava)
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
            this.drzavaNeo4J = drzavaNeo4J;
            this.drzava = drzava;
        }

        private async void BtnAzurirajDrzavu_Click(object sender, EventArgs e)
        {
            drzavaNeo4J.glavniGrad = tbGlavniGrad.Text;
            drzavaNeo4J.opis = tbOpis.Text;
            drzavaNeo4J.sluzbeniJezik = tbSluzbeniJezik.Text;
            await dataProviderNeo4J.UpdateDrzava(drzavaNeo4J.ime, drzavaNeo4J);
            
            if (rbDa.Checked)
            {
                drzava.ImaMore = "Da";
            }
            else
            {
                drzava.ImaMore = "Ne";
            }
            dataProviderCassandra.UpdateDrzava(drzava);

            Close();
        }

        private void DrzavaAzuriranje_Load(object sender, EventArgs e)
        {
            tbIme.Text = drzavaNeo4J.ime;
            tbGlavniGrad.Text = drzavaNeo4J.glavniGrad;
            tbOpis.Text = drzavaNeo4J.opis;
            tbSluzbeniJezik.Text = drzavaNeo4J.sluzbeniJezik;
            if (drzava.ImaMore == "Da")
            {
                rbDa.Checked = true;
                rbNe.Checked = false;
            }
            else
            {
                rbDa.Checked = false;
                rbNe.Checked = true;
            }
            tbGradovi.Text = "";
            foreach(DestinacijaNeo4J destinacija in drzavaNeo4J.Destinacije)
            {
                tbGradovi.Text += destinacija.ime + ", ";
            }
        }
    }
}
