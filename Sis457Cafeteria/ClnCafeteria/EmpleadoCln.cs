using CadCafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnCafeteria
{
    public class EmpleadoCln
    {
        public static int insertar(Empleado empleado)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.Empleado.Add(empleado);
                context.SaveChanges();
                return empleado.idEmpleado;
            }
        }

        public static int actualizar(Empleado empleado)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Empleado.Find(empleado.idEmpleado);
                existente.nombre = empleado.nombre;
                existente.apellidoPaterno = empleado.apellidoPaterno;
                existente.apellidoMaterno = empleado.apellidoMaterno;
                existente.telefono = empleado.telefono;
                existente.direccion = empleado.direccion;
                existente.cargo = empleado.cargo;
                existente.salario = empleado.salario;
                existente.usuarioRegistro = empleado.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int idEmpleado, string usuarioRegistro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Empleado.Find(idEmpleado);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static Empleado get(int idEmpleado)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Empleado.Find(idEmpleado);
            }
        }

        public static List<Empleado> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Empleado.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paEmpleadoListar_Result> listarPa(string parametro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.paEmpleadoListar(parametro).ToList();
            }
        }
    }
}
