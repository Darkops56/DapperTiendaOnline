namespace TiendaOnline.Core;

public class Ubicacion
{
    public int idUbicacion { get; set; }
    public string direccion { get; set; }
    public string ciudad { get; set; }
    public string provincia { get; set; }
    public string codigoPostal { get; set; }
    public Pais pais { get; set; }
}
