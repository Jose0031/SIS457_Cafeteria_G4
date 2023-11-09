using CadCafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnCafeteria
{
    public class VentaCln
    {
        public static int insertar(Venta venta)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.Venta.Add(venta);
                context.SaveChanges();
                return venta.id;
            }
        }

        public static int actualizar(Venta venta)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Venta.Find(venta.id);
                existente.idCliente = venta.idCliente;
                existente.totalVenta = venta.totalVenta;
                existente.usuarioRegistro = venta.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Venta.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();

            }
        }

        public static Venta get(int id)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Venta.Find(id);

            }
        }

        public static List<Venta> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Venta.Where(x => x.estado != -1).ToList();

            }
        }

        public static List<paVentaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.paVentaListar(parametro).ToList();

            }
        }
    }
}
