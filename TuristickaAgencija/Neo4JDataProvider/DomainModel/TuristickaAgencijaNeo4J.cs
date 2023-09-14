using System.Collections.Generic;

namespace Neo4JDataProvider.DomainModel
{
    public class TuristickaAgencijaNeo4J
    {
        public string id { get; set; }
        public string ime { get; set; }
        public string vlasnik { get; set; }

        public string opis { get; set; }
        public string sediste { get; set; }
        public string radnoVreme { get; set; }
        public string listaFilijala { get; set; }
        public string kontaktTel { get; set; }
        public string cekovi { get; set; }
        public string rate { get; set; }
        public List<string> listaSlika { get; set; }
        public List<DrzavaNeo4J> Drzave { get; set; }
    }
}
