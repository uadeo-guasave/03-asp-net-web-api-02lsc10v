using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Cliente
    {
        [Key]
        public int Cuenta { get; set; }
        public int Contrato { get; set; }
        public string Medidor { get; set; }
        public string ClaveDeLocalizacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int DomicilioId { get; set; }

        public Domicilio Domicilio { get; set; }
        public List<Recibo> Recibos { get; set; }
    }
}