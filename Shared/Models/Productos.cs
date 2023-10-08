using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Jerez_Caceres.Shared.Models
{
    public class Productos
    {
        [Key]

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La descripcion es un campo obligatorio")]
        public string Descripcion { get; set; } = string.Empty;

        public int Tipo { get; set; }

        public float Existencia { get; set; }
    }
}
