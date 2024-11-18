using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tl2_tp5_2024_miguell29.Repository;

namespace TP6.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IProductoRepository _productoRepository;
        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
            _productoRepository = new ProductoRepository();
        }

        public IActionResult Index()
        {
            return View(_productoRepository.GetProducts());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}