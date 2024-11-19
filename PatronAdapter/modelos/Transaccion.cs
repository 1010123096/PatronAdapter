namespace PatronAdapter.modelos
{
    public class Transaccion
    {
        public  string idTransaccion {get; set;}
        public int montoTotal { get; set; } 
        public string codigoDivisa { get; set; }
        public string detalles { get; set; }
    }
}
