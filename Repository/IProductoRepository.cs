using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Models;

namespace Repository
{
    public interface IProductoRepository
    {
        public void NewProduct(Producto producto);
        public void UpdateProduct(int id, Producto producto);
        public List<Producto> GetProducts();
        public Producto GetProductById(int id);
        public void DeleteProduct(int id);
    }

}