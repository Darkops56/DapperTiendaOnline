namespace TiendaOnline.Core;

public class Registro
{
    public int idRegistro { get; set; }
    public Usuario usuario { get; set; }
    public DateOnly FechaRegistro { get; set; }
}
