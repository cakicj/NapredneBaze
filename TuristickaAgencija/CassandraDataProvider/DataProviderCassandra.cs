﻿using System.Collections.Generic;
using System.Linq;
using CassandraDataProvider.DomainModel;
using Cassandra;

namespace CassandraDataProvider
{
    public class DataProviderCassandra
    {
        #region Hotel
        public Hotel GetHotel(string ime)
        {
            ISession session = SessionManager.GetSession();
            Hotel hotel = new Hotel();

            if (session == null)
                return null;

            Row hotelData = session.Execute("select * from \"Hotel\" where \"ime\"='" + ime + "'").FirstOrDefault();

            if (hotelData != null)
            {
                hotel.Ime = hotelData["ime"] != null ? hotelData["ime"].ToString() : string.Empty;
                hotel.Ocena = hotelData["ocena"] != null ? hotelData["ocena"].ToString() : string.Empty;
                hotel.Zvezdice = hotelData["brzvezdica"] != null ? hotelData["brzvezdica"].ToString() : string.Empty;
                hotel.UdaljenostOdPlaze = hotelData["udaljenostodplaze"] != null ? hotelData["udaljenostodplaze"].ToString() : string.Empty;
            }

            return hotel;
        }

        public List<Hotel> GetHotels()
        {
            ISession session = SessionManager.GetSession();
            List<Hotel> hotels = new List<Hotel>();


            if (session == null)
                return null;

            var hotelsData = session.Execute("select * from \"Hotel\"");


            foreach (var hotelData in hotelsData)
            {
                Hotel hotel = new Hotel
                {
                    Ime = hotelData["ime"] != null ? hotelData["ime"].ToString() : string.Empty,
                    Ocena = hotelData["ocena"] != null ? hotelData["ocena"].ToString() : string.Empty,
                    Zvezdice = hotelData["brzvezdica"] != null ? hotelData["brzvezdica"].ToString() : string.Empty,
                    UdaljenostOdPlaze = hotelData["udaljenostodplaze"] != null ? hotelData["udaljenostodplaze"].ToString() : string.Empty
                };
                hotels.Add(hotel);
            }
            return hotels;
        }

        public void AddHotel(Hotel hotel)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("insert into \"Hotel\" (ime, ocena, brzvezdica, udaljenostodplaze)  values ('" + hotel.Ime + "', '"
                + hotel.Ocena + "', '" + hotel.Zvezdice + "', '" + hotel.UdaljenostOdPlaze + "')");
        }

        public void DeleteHotel(string ime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("delete from \"Hotel\" where \"ime\" = '" + ime + "'");

        }

        public void UpdateHotel(Hotel hotel)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("update \"Hotel\" set \"ocena\" = '" + hotel.Ocena + "', \"brzvezdica\" = '" + hotel.Zvezdice + "', \"udaljenostodplaze\" = '" + hotel.UdaljenostOdPlaze + 
                "'where \"ime\" = '" + hotel.Ime + "'");
        }
        #endregion

        #region Drzava

        public Drzava GetDrzava(string ime)
        {
            ISession session = SessionManager.GetSession();
            Drzava drzava = new Drzava();

            if (session == null)
                return null;

            Row drzavaData = session.Execute("select * from \"Drzava\" where \"ime\"='" + ime + "'").FirstOrDefault();

            if (drzavaData != null)
            {
                drzava.Ime = drzavaData["ime"] != null ? drzavaData["ime"].ToString() : string.Empty;
                drzava.ImaMore = drzavaData["imamore"] != null ? drzavaData["imamore"].ToString() : string.Empty;
            }

            return drzava;
        }

        public List<Drzava> GetDrzavas()
        {
            ISession session = SessionManager.GetSession();
            List<Drzava> drzave = new List<Drzava>();


            if (session == null)
                return null;

            var drzavasData = session.Execute("select * from \"Drzava\"");


            foreach (var drzavaData in drzavasData)
            {
                Drzava drzava = new Drzava
                {
                    Ime = drzavaData["ime"] != null ? drzavaData["ime"].ToString() : string.Empty,
                    ImaMore = drzavaData["imamore"] != null ? drzavaData["imamore"].ToString() : string.Empty
                };
                drzave.Add(drzava);
            }
            return drzave;
        }

        public void AddDrzava(Drzava drzava)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("insert into \"Drzava\" (ime, imamore)  values ('" + drzava.Ime + "', '" + drzava.ImaMore + "')");

        }

        public void DeleteDrzava(string ime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("delete from \"Drzava\" where \"ime\"='" + ime + "'");

        }

        public void UpdateDrzava(Drzava drzava)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("update \"Drzava\" set \"imamore\" = '" + drzava.ImaMore + "' where \"ime\" = '" + drzava.Ime + "'");
        }
        #endregion


        #region Destinacija

        public Destinacija GetDestinacija(string ime)
        {
            ISession session = SessionManager.GetSession();
            Destinacija destinacija = new Destinacija();

            if (session == null)
                return null;

            Row destinacijaData = session.Execute("select * from \"Grad\" where \"naziv\"='" + ime + "'").FirstOrDefault();

            if (destinacijaData != null)
            {
                destinacija.Ime = destinacijaData["naziv"] != null ? destinacijaData["naziv"].ToString() : string.Empty;
                destinacija.BrStanovnika = destinacijaData["brljudi"] != null ? destinacijaData["brljudi"].ToString() : string.Empty;
            }

            return destinacija;
        }

        public List<Destinacija> GetDestinacijas()
        {
            ISession session = SessionManager.GetSession();
            List<Destinacija> destinacijas = new List<Destinacija>();


            if (session == null)
                return null;

            var destinacijasData = session.Execute("select * from \"Grad\"");


            foreach (var destinacijaData in destinacijasData)
            {
                Destinacija destinacija = new Destinacija
                {
                    Ime = destinacijaData["naziv"] != null ? destinacijaData["naziv"].ToString() : string.Empty,
                    BrStanovnika = destinacijaData["brljudi"] != null ? destinacijaData["brljudi"].ToString() : string.Empty
                };
                destinacijas.Add(destinacija);
            }
            return destinacijas;
        }

        public void AddDestinacija(Destinacija destinacija)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("insert into \"Grad\" (naziv, brljudi)  values ('" + destinacija.Ime + "', '" + destinacija.BrStanovnika + "')");

        }

        public void DeleteDestinacija(string ime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("delete from \"Grad\" where \"naziv\" = '" + ime + "'");

        }

        public void UpdateDestinacija(Destinacija destinacija)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("update \"Grad\" set \"brljudi\" = '" + destinacija.BrStanovnika + "' where \"naziv\" = '" + destinacija.Ime + "'");
        }
        #endregion

        #region TuristickiVodic

        public TuristickiVodic GetVodic(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();
            TuristickiVodic vodic = new TuristickiVodic();

            if (session == null)
                return null;

            Row vodicData = session.Execute("select * from \"Vodic\" where \"ime\"='" + ime + "'and \"prezime\"='" + prezime + "'").FirstOrDefault();

            if (vodicData != null)
            {
                vodic.Ime = vodicData["ime"] != null ? vodicData["ime"].ToString() : string.Empty;
                vodic.Prezime = vodicData["prezime"] != null ? vodicData["prezime"].ToString() : string.Empty;
                vodic.NaDestinaciji = vodicData["godinenadest"] != null ? vodicData["godinenadest"].ToString() : string.Empty;
            }

            return vodic;
        }

        public List<TuristickiVodic> GetVodici()
        {
            ISession session = SessionManager.GetSession();
            List<TuristickiVodic> vodici = new List<TuristickiVodic>();


            if (session == null)
                return null;

            var vodiciData = session.Execute("select * from \"Vodic\"");


            foreach (var vodicData in vodiciData)
            {
                TuristickiVodic vodic = new TuristickiVodic
                {
                    Ime = vodicData["ime"] != null ? vodicData["ime"].ToString() : string.Empty,
                    Prezime = vodicData["prezime"] != null ? vodicData["prezime"].ToString() : string.Empty,
                    NaDestinaciji = vodicData["godinenadest"] != null ? vodicData["godinenadest"].ToString() : string.Empty
                };
                vodici.Add(vodic);
            }
            return vodici;
        }

        public void AddVodic(TuristickiVodic vodic)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("insert into \"Vodic\" (ime, prezime, godinenadest)  values ('" + vodic.Ime + "', '" + vodic.Prezime + "', '" + vodic.NaDestinaciji + "')");

        }

        public void DeleteVodic(string ime, string prezime)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("delete from \"Vodic\" where \"ime\" = '" + ime + "' and \"prezime\"='" + prezime + "'");

        }
        public void UpdateVodic(TuristickiVodic vodic)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            session.Execute("update \"Vodic\" set \"godinenadestinaciji\" = '" + vodic.NaDestinaciji + "' where \"ime\" = '" + vodic.Ime + "' and \"prezime\" = '" + vodic.Prezime + "'");
        }
        #endregion
    }
}
