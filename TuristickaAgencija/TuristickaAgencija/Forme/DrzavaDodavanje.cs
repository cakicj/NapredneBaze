using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Neo4JDataProvider;
using Neo4JDataProvider.DomainModel;
using CassandraDataProvider;
using CassandraDataProvider.DomainModel;

namespace TuristickaAgencija.Forme
{
    public partial class DrzavaDodavanje : Form
    {
        private readonly DataProviderNeo4J dataProviderNeo4J;
        private readonly DataProviderCassandra dataProviderCassandra;
        public DrzavaDodavanje()
        {
            InitializeComponent();
            dataProviderNeo4J = new DataProviderNeo4J();
            dataProviderCassandra = new DataProviderCassandra();
        }

        private async void BtnDodajDrzavu_Click(object sender, EventArgs e)
        {
            DrzavaNeo4J drzavaNeo4J = new DrzavaNeo4J
            {
                ime = tbIme.Text,
                glavniGrad = tbGlavniGrad.Text,
                opis = tbOpis.Text,
                sluzbeniJezik = tbSluzbeniJezik.Text
            };
            string[] gradovi = tbGradovi.Text.Split(' ');
            drzavaNeo4J.Destinacije = new List<DestinacijaNeo4J>();
            foreach (string imeDestinacije in gradovi)
            {
                drzavaNeo4J.Destinacije.Add(await dataProviderNeo4J.GetDestinacija(imeDestinacije));
            }
            await dataProviderNeo4J.AddDrzava(drzavaNeo4J);

            Drzava drzava = new Drzava
            {
                Ime = tbIme.Text,
                ImaMore = rbDa.Checked ? rbDa.Text : rbNe.Text
            };
            dataProviderCassandra.AddDrzava(drzava);

            this.Close();
        }
    }
}
