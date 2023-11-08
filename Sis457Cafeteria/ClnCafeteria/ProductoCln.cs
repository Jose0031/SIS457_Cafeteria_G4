using CadCafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnCafeteria
{
    internal class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.idProducto;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Producto.Find(producto.idProducto);
                existente.codigo = producto.codigo;
                existente.nombre = producto.nombre;
                existente.descripcion = producto.descripcion;
                existente.precio = producto.precio;
                existente.usuarioRegistro = producto.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int idProducto, string usuarioRegistro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Producto.Find(idProducto);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Producto get(int idProducto)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Producto.Find(idProducto);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductosListar_Result> listarPa(string parametro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.paProductosListar(parametro).ToList();
            }
        }
    }
}
