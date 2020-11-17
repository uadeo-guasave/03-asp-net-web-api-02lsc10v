using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Pago
    {
        [Key]
        public int Folio { get; set; }

        [Required, MaxLength(100)]
        public string NombreDelTitular { get; set; }

        [Required, MaxLength(20)]
        public string Tarjeta { get; set; }

        [Required]
        public int Autorizacion { get; set; }

        [Required]
        public System.DateTime FechaDePago { get; set; }

        [Required, MaxLength(200)]
        public string Banco { get; set; }

        [Required]
        public double Importe { get; set; }

        public Recibo Recibo { get; set; }
    }
}