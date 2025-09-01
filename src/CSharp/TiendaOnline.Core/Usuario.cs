namespace TiendaOnline.Core;

public class Usuario
{
    public long idUsuario { get; set; }
    public string apodo { get; set; }
    public string email { get; set; }
    public int idUbicacion { get; set; }
    public Cliente cliente { get; set; }
}
