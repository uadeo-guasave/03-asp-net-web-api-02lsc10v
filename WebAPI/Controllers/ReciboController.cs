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

        // TODO: consultar adeudo
        // TODO: registrar el pago
        // TODO: entregar el comprobante
    }
}