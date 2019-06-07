﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Frigates;
using Factory.CapitalShips;
using Factory.Cruisers;

namespace Factory
{
    public class SimpleFactory
    {
        private static readonly Lazy<SimpleFactory> SimpleInstance =
            new Lazy<SimpleFactory>(() => Activator.CreateInstance(typeof(SimpleFactory), nonPublic: true) as SimpleFactory);
        public static SimpleFactory Instance
        {
            get { return SimpleInstance.Value; }
        }
        private SimpleFactory() { }

        public Frigate CreateFrigate(string frigate)
        {
            switch (frigate)
            {
                case "cobalt":
                    return new Cobalt() as Frigate;
                case "disciple":
                    return new Disciple() as Frigate;
                case "garda":
                    return new Garda() as Frigate;
                case "illuminator":
                    return new Illuminator() as Frigate;
                case "karrastra":
                    return new Karrastra() as Frigate;
                case "ravastra":
                    return new Ravastra() as Frigate;
                default:
                    return null;
            }
        }

        public Cruiser CreateCruiser(string cruiser)
        {
            switch (cruiser)
            {
                case "skarovas":
                    return new Skarovas() as Cruiser;
                case "stilakus":
                    return new Stilakus() as Cruiser;
                case "hoshiko":
                    return new Hoshiko() as Cruiser;
                case "destra":
                    return new Destra() as Cruiser;
                case "aeria":
                    return new Aeria() as Cruiser;
                case "kodiak":
                    return new Kodiak() as Cruiser;
                default:
                    return null;
            }
        }

        public CapitalShip CreateCapitalShip(string capital)
        {
            switch (capital)
            {
                case "discord":
                    return new Discord() as CapitalShip;
                case "jarrasul":
                    return new Jarrasul() as CapitalShip;
                case "kol":
                    return new Kol() as CapitalShip;
                case "rapture":
                    return new Rapture() as CapitalShip;
                case "sova":
                    return new Sova() as CapitalShip;
                case "vulkoras":
                    return new Vulkoras() as CapitalShip;
                default:
                    return null;
            }
        }
    }
}
