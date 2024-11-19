using PatronAdapter.modelos;

namespace PatronAdapter.servicios
{
    public class StripeService
    {
        public async Task StripepagoAsync(DetallesPago detalles)
        {
            await Task.Delay(500); // Simulación de la operación de pago
            Console.WriteLine($"Pago procesado con Stripe: {detalles.monto} {detalles.moneda} - {detalles.descripcion}");
        }
    }
}
