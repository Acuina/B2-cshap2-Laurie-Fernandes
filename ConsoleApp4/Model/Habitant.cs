using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Model
{
    class Habitant
    {
        public string nom;
        public int age;
        public List<Commune> Communes { get; set; }
    }
}
