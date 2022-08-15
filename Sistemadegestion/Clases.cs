
public abstract class DbHandler
{
    public const string ConnectionString = "Server=DESKTOP-67QMF3F;Database=SistemaGestion;Trusted_Connection=TRUE;Encrypt=False;";
}


public class Usuario
{
    public int id;
    public string nombre;
    public string apellido;
    public string NombreUsuario;
    public string contrasenia;
    public string mail;
   
}

public class Producto
{
    public int id;
    public string descripcion;
    public int costo;
    public int PrecioVenta;
    public int stock;
    public int idUsuario;

  
}

public class ProductoVendido
{
    public int id;
    public int stock;
    public int idProducto;
    public int idVenta;

}

public class Venta
{
    public int id;
    public string comentario;

   
}
