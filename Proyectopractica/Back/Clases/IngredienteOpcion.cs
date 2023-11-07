using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class IngredienteOpcion
    {
        [Key]
        public int IdIngredienteopcion { get; set; }

        [ForeignKey(nameof(Ingredientes))]

        public int IdIngrediente { get; set; }

   
        public Ingredientes Ingredientes { get; set; } = null!;

        [ForeignKey(nameof(Opcion))]
        public int IdOpcion { get; set; }   
        public Opcion Opcion { get; set; } = null!;
    }
}
