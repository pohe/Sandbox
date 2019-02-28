using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Drik
    {
        private int _id;
        private string _navn;
        private double _pris;

        private static int counter = 0;


        public double Size { get; set; }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public Drik()
        {
            counter = counter + 1; 
            _navn = "No name";
            _id = counter;
            _pris = 0;
            Size = 0;
        }

        public Drik( string navn, double pris, double size)
        {
            counter = counter + 1;
            _id = counter;
            _navn = navn;
            _pris = pris;
            Size = size;
        }


        public void GivInfo()
        {
            Console.WriteLine($"Drikken har id {ID} hedder {Navn} koster {Pris:00.00}  size {Size}");
        }
    }
}
