using PatronAdapter.modelos;
using PatronAdapter.servicios;
using System.Threading;

namespace PatronAdapter.Adapter
{
    public class StripeAdapter : IProcesoPago
    {
        private readonly StripeService _stripeService;
        public StripeAdapter(StripeService stripeService)
        {
            _stripeService = stripeService;
        }

        public async Task ProcesosDePagoAsync(decimal mmonto, string moneda, string descripcion)
        {

            var pagoDetalles = new DetallesPago
            {
                monto = mmonto,
                moneda = moneda,
                descripcion = descripcion
            };
            await _stripeService.StripepagoAsync(pagoDetalles);
           
        }
    }
}
