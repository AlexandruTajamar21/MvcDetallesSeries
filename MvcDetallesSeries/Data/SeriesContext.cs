using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDetallesSeries.Models;

namespace MvcDetallesSeries.Data
{
    public class SeriesContext : DbContext
    {
        public SeriesContext
            (DbContextOptions<SeriesContext> options)
            : base(options) { }
        public DbSet<Serie> Series { get; set; }
    }
}
