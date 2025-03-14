namespace ITMApi.Models
{
    public class Computador
    {
        public int Id { get; set; }
        public int NumeroProcesadores { get; set; }
        public string MarcaProcesador { get; set; }
        public string TamanioDiscoDuro { get; set; }
        public string TamanioMemoria { get; set; }
        public string Componentes { get; set; }
        public int TipoComputadorId { get; set; }
        public TipoComputador TipoComputador { get; set; }
    }
}