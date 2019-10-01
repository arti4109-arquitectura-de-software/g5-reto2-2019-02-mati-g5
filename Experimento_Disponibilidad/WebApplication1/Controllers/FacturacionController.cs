using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FacturacionController : Controller
    {
        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
            
        }

        public JsonResult ListarProducto()
        {

            Model1 CE = new Model1();
                     
            return Json(CE.Producto.ToList(),JsonRequestBehavior.AllowGet);

        }

        public JsonResult ListarVenta()
        {

            Model1 CE = new Model1();

            return Json(CE.PuntoVenta.ToList(), JsonRequestBehavior.AllowGet);

        }


        public JsonResult Crear(FacturaModel fm)
        {
            Factura fc = new  Factura();
            fc.Cantidad = fm.Cantidad;
            fc.Total = fm.Total;
            fc.IdFactura = fm.IdFactura*2;
            fc.IdProducto = fm.IdProducto;

            Model1 CE = new Model1();
            CE.Factura.Add(fc);

            CE.SaveChanges();
              return Json(new { OK = "OK" });

        }


    }
}