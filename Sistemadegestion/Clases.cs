
public abstract class DbHandler
{
    public const string ConnectionString = "Server=DESKTOP-67QMF3F;Database=SistemaGestion;Trusted_Connection=TRUE;Encrypt=False;";
}


public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public string Contrasenia { get; set; }
    public string Mail { get; set; }
   
}

public class Producto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public int Costo { get; set; }
    public int PrecioVenta { get; set; }
    public int Stock { get; set; }
    public int IdUsuario { get; set; }

  
}

public class ProductoVendido
{
    public int Id { get; set; }
    public int Stock { get; set; }
    public int IdProducto { get; set; }
    public int IdVenta { get; set; }
}

public class Venta
{
    public int Id { get; set; }
    public string Comentario { get; set; }

}
