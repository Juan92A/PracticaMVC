using Microsoft.AspNetCore.Mvc;
using PracticaMVC.Models;

namespace PracticaMVC.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _context;
        public EquiposController(equiposDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create([Bind("nombre,descripcion,tipo_quipo_id,marca_id,modelo,anio_compra,costo,vida_util,estado_equipo_id")] Equipos equipo) {
           
            return View("Index");
        }
    }
}
