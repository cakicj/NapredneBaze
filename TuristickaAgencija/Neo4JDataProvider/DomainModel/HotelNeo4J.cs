using System.Collections.Generic;

namespace Neo4JDataProvider.DomainModel
{
    public class HotelNeo4J
    {
        public string id { get; set; }
        public string ime { get; set; }
        public string opis { get; set; }
        public string Destinacija { get; set; }

        public string komentari { get; set; }
        public string listaKodova { get; set; }
        public List<string> listaSlika { get; set; }
        public List<TuristickiVodicNeo4J> Vodici { get; set; }
    }
}
