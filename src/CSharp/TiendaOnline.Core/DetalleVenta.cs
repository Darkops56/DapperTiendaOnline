namespace TiendaOnline.Core;

public class DetalleVenta
{
    public uint idDetalleVenta { get; set; }
    public long venta { get; set; }
    public int producto { get; set; }
    public uint cantidad { get; set; }
    public uint precioUnitario { get; set; }
}
