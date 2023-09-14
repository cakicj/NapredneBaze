using System.Collections.Generic;

namespace Neo4JDataProvider.DomainModel
{
    public class DrzavaNeo4J
    {
        public string id { get; set; }
        public string ime { get; set; }
        public string glavniGrad { get; set; }

        public string sluzbeniJezik { get; set; }
        public string opis { get; set; }
        public List<DestinacijaNeo4J> Destinacije { get; set; }
    }
}
