using Microsoft.AspNetCore.Mvc;
using WebAPI.DbContexts;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/recibo")]
    public class ReciboController : ControllerBase
    {
        private readonly SqliteDbContext db;
        public ReciboController(SqliteDbContext db)
        {
            this.db = db;
        }

        // todas las acciones deben operar utilizando el método POST

        // TODO: consultar adeudo
        // recibe como parametro un numero de cuenta de cliente
        // si no tiene adeudo regresa en formato json {"Pagado":true}
        // si tiene adeudo regresa en formato json un objeto de tipo Recibo

        // TODO: registrar el pago
        // recibe como parametro un objeto de tipo Pago
        // registra el pago correspondiente
        // muestra el comprobante de pago (se debe mostrar el Folio del pago)

        // TODO: entregar el comprobante
        // recibe como parametro el numero de cuenta de cliente
        // retorna el último comprobante de pago registrado
        // en caso de no tener pagos registrados regresa objeto en json {"sin_pagos":true}
    }
}