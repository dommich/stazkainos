using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace stazkainos.Models
{
    public class Fund
    {
        public DateTime Data { get; set; }
        public double Wartosc { get; set; }
    }
    public class stazkainos_db : DbContext
    {
        public DbSet<Fund> Funds { get; set; }
    }
}
