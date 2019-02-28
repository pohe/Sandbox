using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Mad
    {
        private int _id;
        private string _navn; //alle ordrer navnene på nye linjer
        private double _pris; //total prisen
        private bool _allergener; //er der nogle allergener

        //private int nr1 = 0;
        //private string nr1Navn = "Kyllingebryst";
        //private double nr1Pris = 100;
        //private bool nr1Allergener = false;
        //private int nr2 = 0;
        //private string nr2Navn = "Kamsteg";
        //private double nr2Pris = 250;
        //private bool nr2Allergener = false;
        //private int nr3 = 0;
        //private string nr3Navn = "Nødemix";
        //private double nr3Pris = 20;
        //private bool nr3Allergener = true;

        public Mad(int id)
        {
            _id = id;
        }

        public Mad()
        {
            
        }
        public Mad(int id, string navn, double pris, bool allergener)
        {
            _id = id;
            _navn = navn;
            _pris = pris;
            _allergener = allergener;
        }

        #region properties
        public int Id
        {
            get { return _id; }
        }

        public string Navn
        {
            get
            {
                //Calc();
                return _navn;
            }
        }

        public double Pris
        {
            get
            {
                //Calc();
                return _pris;
            }
        }

        public bool Allergener
        {
            get
            {
                //Calc();
                return _allergener;
            }
        }
        #endregion

        //public void EnMere(int retNummer)
        //{

        //    if (retNummer == 1)
        //    {
        //        nr1++;
        //    }

        //    else if (retNummer == 2)
        //    {
        //        nr2++;
        //    }

        //    else if (retNummer == 3)
        //    {
        //        nr3++;
        //    }
        //    /*
        //    _pris = (nr1 * 100) + (nr2 * 250) + (nr3 * 20);
        //    _navn = $"Kyllingebryst x {nr1} \nKamsteg x {nr2} \nNødemix x {nr3}";
        //    if (nr3 != 0)
        //    {
        //        _allergener = true;
        //    }*/
        //}

        //public void Calc()
        //{
        //    if (nr1 != 0)
        //    {
        //        _navn += $"{nr1Navn} x {nr1}\n";
        //        _pris += nr1Pris;
        //        if (!_allergener) _allergener = nr1Allergener;
        //    }
        //    if (nr2 != 0)
        //    {
        //        _navn += $"{nr2Navn} x {nr2}\n";
        //        _pris += nr2Pris;
        //        if (!_allergener) _allergener = nr2Allergener;
        //    }
        //    if (nr3 != 0)
        //    {
        //        _navn += $"{nr3Navn} x {nr3}\n";
        //        _pris += nr3Pris;
        //        if (!_allergener) _allergener = nr3Allergener;
        //    }
        //}


    }
}



