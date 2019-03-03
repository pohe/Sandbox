using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Kunde
    {
        public string Name { get; set; }
        public string Mobilnr { get; set; }

        public Kunde(string name, string mobilnr)
        {
            Name = name;
            Mobilnr = mobilnr;
        }


    }
}
