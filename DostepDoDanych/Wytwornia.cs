using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DostepDoDanych
{
    public class Wytwornia
    {
        public int WytworniaID { get; set; }
        public string  Nazwa { get; set; }
        public string Narodowosc { get; set; }

        public virtual List<Film> Filmy { get; set; }
    }
}
