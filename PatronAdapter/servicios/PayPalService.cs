using PatronAdapter.modelos;
using System.Transactions;

namespace PatronAdapter.servicios
{
    public class PayPalService
    { 
    public async Task ejecutarTransactionAsync(Transaccion transaccion)
    {
        await Task.Delay(500); 
        Console.WriteLine($"Pago procesado con PayPal: {transaccion.montoTotal} {transaccion.codigoDivisa} - {transaccion.detalles} - ID de transacción: {transaccion.idTransaccion}");
    }
}
}
