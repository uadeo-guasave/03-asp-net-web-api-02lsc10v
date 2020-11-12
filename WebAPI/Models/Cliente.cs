namespace WebAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int NumeroDeCuenta { get; set; }
        public int NumeroDeContrato { get; set; }
        public string Medidor { get; set; }
        public string ClaveDeLocalizacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int DomicilioId { get; set; }

        public Domicilio Domicilio { get; set; }
        public Recibo Recibo { get; set; }
    }
}