using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Neo4jClient;
using Neo4jClient.Cypher;
using Neo4JDataProvider.DomainModel;

namespace Neo4JDataProvider
{
    public class DataProviderNeo4J
    {
        private readonly GraphClient client;

        public DataProviderNeo4J()
        {
            client = new GraphClient(new Uri("http://localhost:7474/"), "neo4j", "projekat2");
            client.ConnectAsync().Wait();
        }

        #region Destinacija
        public async Task<DestinacijaNeo4J> GetDestinacija(string ime)
        {
            DestinacijaNeo4J destinacija = new DestinacijaNeo4J();
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                { "ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) WHERE n.ime='" + ime +"' RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);

            foreach(DestinacijaNeo4J destinacija1 in destinacije)
            {
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija)-[r:PripadaDrzavi]->(b) WHERE n.ime='" + ime + "' RETURN b",
                                                                queryDict, CypherResultMode.Set, "neo4j");

                IEnumerable<DrzavaNeo4J> drzave = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query2);

                foreach(DrzavaNeo4J drzava in drzave)
                {
                    destinacija1.Drzava = drzava.ime;
                }

                var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija)-[r:imaHotel]->(b) WHERE n.ime='" + ime + "' RETURN b",
                                                                queryDict, CypherResultMode.Set, "neo4j");

                IEnumerable<HotelNeo4J> hoteli = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query3);
                destinacija1.Hoteli = new List<HotelNeo4J>();
                foreach (HotelNeo4J hotel in hoteli)
                {
                    destinacija1.Hoteli.Add(hotel);
                }

                destinacija = destinacija1;
            }
            return destinacija;
        }

        public async Task<List<DestinacijaNeo4J>> GetDestinacijas()
        {
            List<DestinacijaNeo4J> destinacijas = new List<DestinacijaNeo4J>();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);

            foreach (DestinacijaNeo4J destinacija in destinacije)
            {
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>
                {
                    { "ime", "'" + destinacija.ime + "'" }
                };

                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija)-[r:PripadaDrzavi]->(b) WHERE n.ime='" + destinacija.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");

                IEnumerable<DrzavaNeo4J> drzave = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query2);

                foreach (DrzavaNeo4J drzava in drzave)
                {
                    destinacija.Drzava = drzava.ime;
                }

                var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija)-[r:imaHotel]->(b) WHERE n.ime='" + destinacija.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");

                IEnumerable<HotelNeo4J> hoteli = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query3);

                foreach (HotelNeo4J hotel in hoteli)
                {
                    destinacija.Hoteli.Add(hotel);
                }

                destinacijas.Add(destinacija);
            }
            return destinacijas;
        }

        public async Task AddDestinacija(DestinacijaNeo4J destinacija)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + destinacija.ime + "'" },
                {"opis", "'" + destinacija.opis + "'" },
                {"duzinaPlaze", "'" + destinacija.duzinaPlaze + "'" },
                {"imaMore", "'" + destinacija.imaMore + "'" },
                {"listaSlika", "'" + destinacija.listaSlika + "'" }
            };
            if (destinacija.imaMore == "Da")
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:Destinacija{ime:'" + destinacija.ime + ", opis: '" + destinacija.opis + ", duzinaPlaze:'" +
                    destinacija.duzinaPlaze + "', imaMore:'" + destinacija.imaMore + "', listaSlika:[" + destinacija.listaSlika.ToArray() + "]}) RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
            }
            else
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:Destinacija{ime:'" + destinacija.ime + ", opis: '" + destinacija.opis + 
                    "', imaMore:'" + destinacija.imaMore + "', listaSlika:[" + destinacija.listaSlika.ToArray() + "]}) RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
            }
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Destinacija), (b:Drzava) WHERE n.ime='" + destinacija.ime + "' AND b.ime='" + destinacija.Drzava + 
                "' CREATE (n)-[r:pripadaDrzavi]->(b) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);
            query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Destinacija), (b:Drzava) WHERE n.ime='" + destinacija.ime + "' AND b.ime='" + destinacija.Drzava +
                "' CREATE (b)-[r:imaGrad]->(n) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);
            foreach (HotelNeo4J hotel in destinacija.Hoteli)
            {
                var query = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Destinacija), (b:Hotel) WHERE n.ime='" + destinacija.ime + "' AND b.ime='" + hotel.ime +
                "' CREATE (n)-[r:imaHotel]->(b) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
                query = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Destinacija), (b:Hotel) WHERE n.ime='" + destinacija.ime + "' AND b.ime='" + hotel.ime +
                "' CREATE (b)-[r:pripadaDestinaciji]->(n) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
            }
        }

        public async Task DeleteDestinacija(string ime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) WHERE n.ime='" + ime + "' DETACH DELETE n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
        }

        public async Task UpdateDestinacija(string ime, DestinacijaNeo4J destinacija)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) WHERE n.ime='" + ime + "' SET n.ime='" + destinacija.ime + "', n.opis='" + destinacija.opis + "'" + ", n.duzinaPlaze='" 
                + destinacija.duzinaPlaze + "', n.imaMore='" + destinacija.imaMore + "', n.listaSlika=[" + destinacija.listaSlika.ToArray() + "] RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
        }
        #endregion

        #region Drzava
        public async Task<DrzavaNeo4J> GetDrzava(string ime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                { "ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava) WHERE n.ime='" + ime + "' RETURN n", queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<DrzavaNeo4J> drzave = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query);
            foreach (DrzavaNeo4J drzava1 in drzave)
            {
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava)-[r:ImaGrad]->(b) WHERE n.ime='" + ime + "' RETURN b",
                                                                queryDict, CypherResultMode.Set, "neo4j");

                IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);
                drzava1.Destinacije = new List<DestinacijaNeo4J>();
                foreach (DestinacijaNeo4J destinacija in destinacije)
                {
                    drzava1.Destinacije.Add(destinacija);
                }
            }
            return drzave.First();
        }

        public async Task<List<DrzavaNeo4J>> GetDrzavas()
        {
            List<DrzavaNeo4J> drzavas = new List<DrzavaNeo4J>();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava) RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<DrzavaNeo4J> drzave = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query);

            foreach (DrzavaNeo4J drzava in drzave)
            {
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>
                {
                    { "ime", "'" + drzava.ime + "'" }
                };

                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava)-[r:imaGrad]->(b) WHERE n.ime='" + drzava.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");

                IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);

                foreach (DestinacijaNeo4J destinacija in destinacije)
                {
                    drzava.Destinacije.Add(destinacija);
                }

                drzavas.Add(drzava);
            }
            return drzavas;
        }

        public async Task AddDrzava(DrzavaNeo4J drzava)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + drzava.ime + "'" },
                {"opis", "'" + drzava.opis + "'" },
                {"glavniGrad", "'" + drzava.glavniGrad + "'" },
                {"sluzbeniJezik", "'" + drzava.sluzbeniJezik + "'" }
            };
            var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:Destinacija{ime:'" + drzava.ime + ", opis: '" + drzava.opis + ", glavniGrad:'" +
                    drzava.glavniGrad + "', sluzbeniJezik:'" + drzava.sluzbeniJezik + "'}) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
            foreach (DestinacijaNeo4J destinacija in drzava.Destinacije)
            {
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Drzava), (b:Destinacija) WHERE n.ime='" + drzava.ime + "' AND b.ime='" + 
                    destinacija.ime + "' CREATE (n)-[r:imaGrad]->(b) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query2);
                query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Drzava), (b:Destinacija) WHERE n.ime='" + drzava.ime + "' AND b.ime='" + destinacija.ime +
                "' CREATE (b)-[r:pripadaDrzavi]->(n) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query2);
            }
        }

        public async Task DeleteDrzava(string ime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava) WHERE n.ime='" + ime + "' DETACH DELETE n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query);
        }

        public async Task UpdateDrzava(string ime, DrzavaNeo4J drzava)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Drzava) WHERE n.ime='" + ime + "' SET n.ime='" + drzava.ime + "', n.opis='" + drzava.opis + "'" + ", n.glavniGrad='"
                + drzava.glavniGrad + "', n.sluzbeniJezik='" + drzava.sluzbeniJezik + "' RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
        }
        #endregion

        #region Hotel
        public async Task<HotelNeo4J> GetHotel(string ime)
        {
            HotelNeo4J hotel = new HotelNeo4J();
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                { "ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel) WHERE n.ime='" + ime + "' RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<HotelNeo4J> hoteli = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query);

            foreach (HotelNeo4J hotel1 in hoteli)
            {
                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel)-[r:PripadaDestinaciji]->(b) WHERE n.ime='" + ime + "' RETURN b",
                                                                queryDict, CypherResultMode.Set, "neo4j");

                IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);

                foreach (DestinacijaNeo4J destinacija in destinacije)
                {
                    hotel1.Destinacija = destinacija.ime;
                }

                var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel)-[r:imaVodica]->(b) WHERE n.ime='" + ime + "' RETURN b",
                                                                queryDict, CypherResultMode.Set, "neo4j");

                IEnumerable<TuristickiVodicNeo4J> vodici = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query3);

                hotel1.Vodici = new List<TuristickiVodicNeo4J>();
                foreach (TuristickiVodicNeo4J vodic in vodici)
                {
                    hotel1.Vodici.Add(vodic);
                }

                hotel = hotel1;
            }
            return hotel;
        }

        public async Task<List<HotelNeo4J>> GetHotels()
        {
            List<HotelNeo4J> hotels = new List<HotelNeo4J>();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel) RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<HotelNeo4J> hoteli = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query);

            foreach (HotelNeo4J hotel in hoteli)
            {
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>
                {
                    { "ime", "'" + hotel.ime + "'" }
                };

                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel)-[r:pripadaDestinaciji]->(b) WHERE n.ime='" + hotel.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");

                IEnumerable<DestinacijaNeo4J> destinacije = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query2);

                foreach (DestinacijaNeo4J destinacija in destinacije)
                {
                    hotel.Destinacija = destinacija.ime;
                }

                var query3 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel)-[r:imaVodica]->(b) WHERE n.ime='" + hotel.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");

                IEnumerable<TuristickiVodicNeo4J> vodici = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query3);

                foreach (TuristickiVodicNeo4J vodic in vodici)
                {
                    hotel.Vodici.Add(vodic);
                }

                hotels.Add(hotel);
            }
            return hotels;
        }

        public async Task AddHotel(HotelNeo4J hotel)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + hotel.ime + "'" },
                {"opis", "'" + hotel.opis + "'" },
                {"komentari", "'" + hotel.komentari + "'" },
                {"listaKodova", "'" + hotel.listaKodova + "'" },
                {"listaSlika", "'" + hotel.listaSlika + "'" }
            };
            var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:Hotel{ime:'" + hotel.ime + ", opis: '" + hotel.opis + ", komentari:'" +
                hotel.komentari + "', listaKodova:'" + hotel.listaKodova + "', listaSlika:" + hotel.listaSlika + "}) RETURN n", 
                queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query);
            var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Hotel), (b:Destinacija) WHERE n.ime='" + hotel.ime + "' AND b.ime='" + hotel.Destinacija
                + "' CREATE (n)-[r:pripadaDestinaciji]->(b) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query2);
            query2 = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Hotel), (b:Destinacija) WHERE n.ime='" + hotel.ime + "' AND b.ime='" + hotel.Destinacija +
                "' CREATE (b)-[r:imaHotel]->(n) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query2);
            foreach (TuristickiVodicNeo4J vodic in hotel.Vodici)
            {
                query = new Neo4jClient.Cypher.CypherQuery("MATCH(n:Hotel), (b:Vodic) WHERE n.ime='" + hotel.ime + "' AND b.ime='" + vodic.ime +
                "' CREATE (n)-[r:imaVodica]->(b) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
                _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query);
            }
        }

        public async Task DeleteHotel(string ime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Hotel) WHERE n.ime='" + ime + "' DETACH DELETE n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<HotelNeo4J>(query);
        }

        public async Task UpdateHotel(string ime, HotelNeo4J hotel)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) WHERE n.ime='" + ime + "' SET n.ime='" + hotel.ime + "', n.opis='" + hotel.opis + "'" + ", n.komentari='"
                + hotel.komentari + "', n.listaKodova='" + hotel.listaKodova + "', n.listaSlika=[" + hotel.listaSlika.ToArray() + "] RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
        }
        #endregion

        #region TuristickaAgencija
        public async Task<TuristickaAgencijaNeo4J> GetAgencija()
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:TuristickaAgencija) RETURN n", queryDict, CypherResultMode.Set, "neo4j");

            IRawGraphClient client1 = client;
            var agencije = await client1.ExecuteGetCypherResultsAsync<TuristickaAgencijaNeo4J>(query);

            foreach (TuristickaAgencijaNeo4J agencija in agencije)
            {
                Dictionary<string, object> queryDict2 = new Dictionary<string, object>
                {
                    { "ime", "'" + agencija.ime + "'" }
                };

                var query2 = new Neo4jClient.Cypher.CypherQuery("MATCH (n:TuristickaAgencija)-[r:Nudi]->(b) WHERE n.ime='" + agencija.ime + "' RETURN b",
                                                                queryDict2, CypherResultMode.Set, "neo4j");
                agencija.Drzave = new List<DrzavaNeo4J>();

                IEnumerable<DrzavaNeo4J> drzave = (await client1.ExecuteGetCypherResultsAsync<DrzavaNeo4J>(query2));

                foreach (DrzavaNeo4J drzava in drzave)
                {
                    agencija.Drzave.Add(drzava);
                }
            }
            return agencije.First();
        }
        #endregion

        #region TuristickiVodic
        public async Task<TuristickiVodicNeo4J> GetVodic(string ime, string prezime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                { "ime", "'" + ime + "'" },
                { "prezime", "'" + prezime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Vodic) WHERE n.ime='" + ime + "' AND n.prezime='" + prezime + "' RETURN n",
                                                            queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<TuristickiVodicNeo4J> vodici = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query);
            return vodici.First();
        }

        public async Task<List<TuristickiVodicNeo4J>> GetVodics()
        {
            List<TuristickiVodicNeo4J> vodics = new List<TuristickiVodicNeo4J>();
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Vodic) RETURN n", queryDict, CypherResultMode.Set, "neo4j");

            IEnumerable<TuristickiVodicNeo4J> vodici = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query);
            
            foreach(TuristickiVodicNeo4J vodic in vodici)
            {
                vodics.Add(vodic);
            }
            return vodics;
        }

        public async Task AddVodic(TuristickiVodicNeo4J vodic)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + vodic.ime + "'" },
                {"prezime", "'" + vodic.prezime + "'" },
                {"jezici", "'" + vodic.govori + "'" },
                {"uTurizmu", "'" + vodic.uTurizmu + "'" }
            };
            var query = new Neo4jClient.Cypher.CypherQuery("MERGE (n:Vodic {ime:'" + vodic.ime + ", prezime: '" + vodic.prezime + ", govori:'" +
                vodic.govori + "', uTurizmu:'" + vodic.uTurizmu + "'}) RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query);
        }

        public async Task DeleteVodic(string ime, string prezime)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" },
                {"prezime", "'" + prezime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Vodic) WHERE n.ime='" + ime + "' AND n.prezime='" + prezime + "' DETACH DELETE n",
                                                            queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<TuristickiVodicNeo4J>(query);
        }

        public async Task UpdateVodic(string ime, string prezime, TuristickiVodicNeo4J vodic)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>
            {
                {"ime", "'" + ime + "'" },
                {"prezime", "'" + prezime + "'" }
            };

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Destinacija) WHERE n.ime='" + ime + "' AND n.prezime='" + prezime + "' SET n.ime='" + vodic.ime + "', n.prezime='" + vodic.prezime + "'"
                + ", n.govori='"+ vodic.govori + "', n.uTurizmu='" + vodic.uTurizmu + "' RETURN n", queryDict, CypherResultMode.Set, "neo4j");
            _ = await ((IRawGraphClient)client).ExecuteGetCypherResultsAsync<DestinacijaNeo4J>(query);
        }
        #endregion
    }
}
