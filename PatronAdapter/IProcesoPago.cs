namespace PatronAdapter
{
    public interface IProcesoPago
    {
        Task ProcesosDePagoAsync(decimal mmonto, string moneda, string descripcion);

    }
}
