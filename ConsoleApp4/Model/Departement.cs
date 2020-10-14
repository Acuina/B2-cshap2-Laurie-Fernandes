using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Model
{
    class Departement
    {
        public string nom;
        public string numero;
        public int numD;
        public List<Commune> Communes { get; set; }
    }
}
