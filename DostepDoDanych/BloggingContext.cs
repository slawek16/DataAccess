using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DostepDoDanych
{
    public class BloggingContext:DbContext
    {
        public DbSet<Aktor> Aktorzy { get; set; }
        public DbSet<Film> Filmy { get; set; }
        public DbSet<Miejsce> Miejsca { get; set; }
        public DbSet<Wytwornia> Wytwornie { get; set; }
    }
}
