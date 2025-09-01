namespace TiendaOnline.Core;

public class Pedidos
{
    public int idPedido { get; set; }
    public Usuario usuario { get; set; }
    public Carrito carrito { get; set; }
    public string estado { get; set; }
    public DateTime fechaPedido { get; set; }
    public string direccion { get; set; }
    public string formaPago { get; set; }
    public byte total { get; set; }
}
