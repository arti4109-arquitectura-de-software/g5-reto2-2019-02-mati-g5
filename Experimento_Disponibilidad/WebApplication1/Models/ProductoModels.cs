using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reto2Servicio.Models
{
    public class ProductoModels
    {
        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public Nullable<int> PrecioProducto { get; set; }
        public Nullable<int> idPuntoventa { get; set; }
    }
}