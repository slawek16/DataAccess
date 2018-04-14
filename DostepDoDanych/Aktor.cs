using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DostepDoDanych
{
    public class Aktor
    {
        public int AktorID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public virtual Miejsce MiejsceUrodzenia { get; set; }
        public virtual List<Film> Filmy { get; set; }


    }
}
