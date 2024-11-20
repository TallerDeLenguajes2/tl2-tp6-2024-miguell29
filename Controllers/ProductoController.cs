using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Repository;

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

        public IActionResult AgregarProducto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarProducto(Producto producto)
        {
            _productoRepository.NewProduct(producto);
            var productos = _productoRepository.GetProducts();
            return View("Index", productos);
        }


        public IActionResult Editar(int id)
        {
            var producto = _productoRepository.GetProductById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
        [HttpPost]
        public IActionResult Editar(int id ,Producto producto)
        {
            _productoRepository.UpdateProduct(id, producto);
            var productos = _productoRepository.GetProducts();
            return View("Index", productos);
        }

        public IActionResult Eliminar(int id)
        {
            _productoRepository.DeleteProduct(id);
            var productos = _productoRepository.GetProducts();
            return View("Index",productos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}