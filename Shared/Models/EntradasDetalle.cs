using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Luis_Miguel_Jerez_Caceres.Shared.Models;

public class EntradasDetalle
{
    [Key]

    public int DetalleId { get; set; }

    public int EntradaId { get; set; }

	[Required(ErrorMessage = "Debe elegir un producto")]
	public int ProductoId { get; set; }

    [Required(ErrorMessage ="La cantidad debe ser mayor que 0")]
    public float CantidadUtilizada { get; set; }
}