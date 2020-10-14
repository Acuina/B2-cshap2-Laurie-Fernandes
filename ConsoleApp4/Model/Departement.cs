using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Model
{
    class Departement
    {
        public string nom;
        public int numD;
        public int nbreH;
        public List<Commune> Communes { get; set; }
    }
}
