namespace TiendaOnline.Core;

public class HistorialCompra
{
    public int producto { get; set; }
    public int categoria { get; set; }
    public int pedidos { get; set; }
    public long usuario { get; set; }
    public int ubicacion { get; set; }
    public int precioUnitario { get; set; }
    public DateOnly fecha { get; set; }
}
