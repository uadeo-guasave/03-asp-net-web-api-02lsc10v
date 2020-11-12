namespace WebAPI.Models
{
    public class Pago
    {
        public int Folio { get; set; }
        public int ReciboId { get; set; }
        public string NombreDelTitular { get; set; }
        public string Tarjeta { get; set; }
        public int Autorizacion { get; set; }
        public System.DateTime FechaDePago { get; set; }
        public string Banco { get; set; }
        public double Importe { get; set; }

        public Recibo Recibo { get; set; }
    }
}