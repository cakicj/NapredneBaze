using System.Collections.Generic;

namespace Neo4JDataProvider.DomainModel
{
    public class DestinacijaNeo4J
    {
        public string id { get; set; }

        public string ime { get; set; }
        public string Drzava { get; set; }
        public string opis { get; set; }
        public string duzinaPlaze { get; set; }
        public string imaMore { get; set; }
        public List<string> listaSlika { get; set; }
        public List<HotelNeo4J> Hoteli { get; set; }
    }
}
