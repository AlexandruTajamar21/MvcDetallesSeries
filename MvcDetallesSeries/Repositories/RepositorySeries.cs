using MvcDetallesSeries.Data;
using MvcDetallesSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDetallesSeries.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public Serie GetSerieId(int idSerie)
        {
            var consulta = from datos in this.context.Series
                           where datos.IdSerie == idSerie
                           select datos;
            return consulta.FirstOrDefault();
        }

        internal List<Serie> GetSeries()
        {
            var consulta = from datos in this.context.Series
                           select datos;
            return consulta.ToList();
        }
    }
}
