namespace TiendaOnline.Core;

public class Stock
{
    public int idStock { get; set; }
    public Producto producto { get; set; }
    public int cantidad { get; set; }
    public DateTime fechaActualizacion { get; set; }
}
