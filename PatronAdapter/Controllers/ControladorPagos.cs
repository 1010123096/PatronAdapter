using Microsoft.AspNetCore.Mvc;

namespace PatronAdapter.Controllers
{
    public class ControladorPagos : Controller
    {
        private readonly IProcesoPago _pagos;
        public ControladorPagos(IProcesoPago procesoPago)
        {
            _pagos = procesoPago;
        }
        [HttpPost("procesar")]
        public async Task<IActionResult> ProcesarPago([FromBody] PagoRequest request)
        {
            await _pagos.ProcesosDePagoAsync(request.Amount, request.Currency, request.Description);
            return Ok("Pago procesado exitosamente ");
        }
    }
    public class PagoRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
    }
}
