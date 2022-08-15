using productHandler;




    public class ProbarObjetos
{

    static void Main(string[] args)
    {
      

        UsuarioClaveHandler usuarioClaveHandler = new UsuarioClaveHandler();
        usuarioClaveHandler.GetUsuarioClave();


        UsuarioHandler usuarioHandler = new UsuarioHandler();
        usuarioHandler.GetUsuario();

        ProductoHandler productoHandler = new ProductoHandler();
        productoHandler.GetProducto();

        ProductoVendidoHandler productoVendidoHandler = new ProductoVendidoHandler();
        productoVendidoHandler.GetProductoVendido();

    }
}