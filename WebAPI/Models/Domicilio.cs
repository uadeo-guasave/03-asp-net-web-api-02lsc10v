namespace WebAPI.Models
{
    public class Domicilio
    {
        public int Id { get; set; }
        public string CallePrincipal { get; set; }
        public string CalleA { get; set; }
        public string CalleB { get; set; }
        public int NumeroExterior { get; set; }
        public int NumeroInterior { get; set; }
        public int CodigoPostal { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Colonia { get; set; }

        public Cliente Cliente { get; set; }
    }
}