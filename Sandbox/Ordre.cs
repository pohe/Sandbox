﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Ordre
    {
        private int _ordreNummer;
        private double _pris;
        //private Mad _mad1;
        //private Mad _mad2;
        private List<Mad> _mad;
        private List<Drik> _drikkevarer;
        //private Drik _drik;

        //public Drik Drik
        //{
        //    get { return _drik; }
        //    set { _drik = value; }
        //}

        public Kunde Kunde { get; set; }

        public Ordre(int ordreNummer)
        {
            _ordreNummer = ordreNummer;
            
        }

        public void AddDrikTilOrdre(Drik d)
        {
            _drikkevarer.Add(d);
            //_drik = d;
        }

        public void AddMadTilOrdre(Mad m1)
        {
            _mad.Add(m1);
        }

        //public Mad Mad
        //{
        //    get { return _mad1; }
        //    set { _mad1 = value;  }
        //}

        public int ordreNummer
        {
            get { return _ordreNummer; }
            set { _ordreNummer = value; }
        }

        public double pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        


        public void ordreBeskrivelse(string bestilling)
        {
            Console.WriteLine(bestilling);
            Console.WriteLine($"Du har bestilt {ordreNummer} din ret hedder {_mad1.Navn} den koster {_mad1.Pris}");
        }

    }
}


