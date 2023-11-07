using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Ingredientes
    {
        [Key]
        public int IdIngredientes { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        
        public List<IngredienteOpcion> opciones { get; set; }  = new List<IngredienteOpcion>();

        public override string ToString()
        {
            return this.Nombre + " " + this.Precio;
        }

    }
}
