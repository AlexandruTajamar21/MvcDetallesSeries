using Microsoft.AspNetCore.Mvc;
using MvcDetallesSeries.Models;
using MvcDetallesSeries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDetallesSeries.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetallesSerie(int idSerie)
        {
            Serie serie = this.repo.GetSerieId(idSerie);
            return View(serie);
        }
    }
}
