using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public string NombreDestinatario { get; set; }
        public List<PresupuestoDetalle> Detalle { get; set; }    
        public decimal MontoPresupuesto()
        {
            if (CantidadProductos() == 0)
            {
                return 0;
            }
            return Detalle.Sum(d => d.Cantidad * d.Producto.Precio);
        }
        public void MontoPresupuestoConIva()
        {
            
        }
        public int CantidadProductos()
        {
            return Detalle.Count;
        }
    }
}