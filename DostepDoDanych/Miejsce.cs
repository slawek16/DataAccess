using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DostepDoDanych
{
    public class Miejsce
    {
        public int MiejsceID { get; set; }
        public string Panstwo { get; set; }
        public string Miasto { get; set; }

        public virtual List<Aktor> Aktorzy { get; set; }
    }
}
