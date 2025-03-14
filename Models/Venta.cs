namespace ITMApi.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public int ComputadorId { get; set; }
        public int AgenciaId { get; set; }
    }
}