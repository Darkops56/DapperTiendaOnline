namespace TiendaOnline.Core;

public class Venta
{
    public long idVenta { get; set; }
    public long idUsuario { get; set; }
    public DateTime fecha { get; set; }
    public decimal total { get; set; }
    public string metodoPago { get; set; }
    public string estado { get; set; }
}
