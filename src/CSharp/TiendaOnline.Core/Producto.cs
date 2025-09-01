namespace TiendaOnline.Core;

public class Producto
{
    public int idProducto { get; set; }
    public string nombre { get; set; }
    public int precio { get; set; }
    public string descripcion { get; set; }
    public int idInventario { get; set; }
    public int idGarantia { get; set; }
    public int idCategoria { get; set; }
}
