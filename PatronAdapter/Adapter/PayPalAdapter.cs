using PatronAdapter.modelos;
using PatronAdapter.servicios;
using System.Transactions;

namespace PatronAdapter.Adapter
{
    public class PayPalAdapter : IProcesoPago
    {
        private readonly PayPalService _payPalService;

        public PayPalAdapter(PayPalService payPalService)
        {
            _payPalService = payPalService;
        }
        public async Task ProcesosDePagoAsync(decimal mmonto, string moneda, string descripcion)
        {
            int totalmonto = (int)Math.Round(mmonto);
            string transactionId = Guid.NewGuid().ToString();
            var transaction = new Transaccion
            {
                montoTotal = totalmonto,
                codigoDivisa = moneda,
                detalles = descripcion,
                idTransaccion = transactionId
            };
            await _payPalService.ejecutarTransactionAsync(transaction);
        }
    }
}
