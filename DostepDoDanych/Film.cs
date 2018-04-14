using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DostepDoDanych
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Tytul { get; set; }
        public DateTime DataWydania { get; set; }
        public string Gatunek { get; set; }
        public int Ocena { get; set; }
        
        public virtual Wytwornia Wytwornia { get; set; }    
        public virtual List<Aktor> Obsada { get; set; }
        
    }
}
