


using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;

namespace TP6.Controllers
{
    public class PresupuestoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IPresupuestoRepository _presupuestoRepository;
        public PresupuestoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
            _presupuestoRepository = new PresupuestoRepository();
        }

        public IActionResult Index()
        {
            return View(_presupuestoRepository.GetPresupuestos());
        }


    /*
        public IActionResult AgregarPresupuesto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarPresupuesto(Presupuesto presupuesto)
        {
            _presupuestoRepository.CreatePresupuesto(presupuesto);
            var presupuestos = _presupuestoRepository.GetPresupuestos();
            return View("Index", presupuestos);
        }


        public IActionResult Editar(int id)
        {
            var presupuesto = _presupuestoRepository.GetPresupuestoById(id);
            if (presupuesto == null)
            {
                return NotFound();
            }
            return View(presupuesto);
        }
        [HttpPost]
        

        public IActionResult Eliminar(int id)
        {
            _presupuestoRepository.DeletePresupuesto(id);
            var presupuestos = _presupuestoRepository.GetPresupuestos();
            return View("Index",presupuestos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    */
    }
}