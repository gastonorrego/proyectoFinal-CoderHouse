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


        UsuarioParametroHandler usuarioParemetro = new UsuarioParametroHandler();
        usuarioParemetro.TraerUsuario();


        productoUsuario productoUsuario = new productoUsuario();
        productoUsuario.TraerProducto();


        UsuarioYcontraseña usuariocontraseña = new UsuarioYcontraseña();
        usuariocontraseña.InicioDeSesion();


        UsuarioVentas productosXUsuario = new UsuarioVentas();
        productosXUsuario.TraerProductosVendidos();

    }
}