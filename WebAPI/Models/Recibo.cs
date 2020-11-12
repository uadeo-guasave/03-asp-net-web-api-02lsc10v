namespace WebAPI.Models
{
    public class Recibo
    {
        public int Id { get; set; }
        public string PeriodoDeFacturacion { get; set; }
        public System.DateTime FechaDeInicio { get; set; }
        public System.DateTime FechaDeLectura { get; set; }
        public int LecturaAnterior { get; set; }
        public int LecturaActual { get; set; }
        public int ConsumoEnM3 { get; set; }
        public int MesesDeAdeudo { get; set; }
        public double ConsumoDeAgua { get; set; }
        public double Drenaje { get; set; }
        public double Saneamiento { get; set; }
        public double Bomberos { get; set; }
        public double CruzRoja { get; set; }
        public double Multas { get; set; }
        public double Recargos { get; set; }
        public double ImporteTotal { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}