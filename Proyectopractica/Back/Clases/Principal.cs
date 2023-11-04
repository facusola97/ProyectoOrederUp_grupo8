using Back.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Principal
    {
        public static ApplicationDbContext context = new ApplicationDbContext();

        public static void AgregarOpcion(string nombre, string tipo, string descripcion,decimal precio, int cantidad)
        {
            Opcion opciones = new Opcion()
            {
                Nombre = nombre,
                Tipo = tipo,
                Descripcion = descripcion,
                Precio = precio,
                Cantidad = cantidad,
                
            };

            context.opciones.Add(opciones);
            context.SaveChanges();

        }
        public static void EliminarOpcion(int id)
        {          
            Opcion opcion = context.opciones.Find(id);
            context.opciones.Remove(opcion);
            context.SaveChanges();
        }
        public static void AgregarUsuario(string nombre, string contraseña)
        {
            Usuario usuarios = new Usuario()
            {
                Nombre = nombre,
                Contraseña = contraseña,
                     
            };

            context.usuarios.Add(usuarios);
            context.SaveChanges();

        }

    }
}
