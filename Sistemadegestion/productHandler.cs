
using Microsoft.Data.SqlClient;
using Microsoft.Data;



namespace productHandler
{







    public class ProductoVendidoHandler : DbHandler
    {
        public List<ProductoVendido> GetProductoVendido()
        {
            List<ProductoVendido> ProdVendido = new List<ProductoVendido>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM ProductoVendido", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Productos Vendidos:");
                            while (dataReader.Read())
                            {
                                ProductoVendido ProductoVendido = new ProductoVendido();

                                ProductoVendido.id = Convert.ToInt32(dataReader["Id"]);
                                ProductoVendido.stock = Convert.ToInt32(dataReader["Stock"]);
                                ProductoVendido.idProducto = Convert.ToInt32(dataReader["idProducto"]);
                                ProductoVendido.idVenta = Convert.ToInt32(dataReader["IdVenta"]);


                                ProdVendido.Add(ProductoVendido);

                                Console.WriteLine("Id:  " + ProductoVendido.id);
                                Console.WriteLine("Stock" + ProductoVendido.stock);
                                Console.WriteLine("IdProducto" + ProductoVendido.idProducto);
                                Console.WriteLine("IdVenta" + ProductoVendido.idVenta);
                            }


                            }
                        }
                    }
                }

                return ProdVendido;

            }



        }
    }



    public class UsuarioClaveHandler : DbHandler
    {
        public List<Usuario> GetUsuarioClave()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM usuario", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lista de Usuarios y contraseñas:");
                            while (dataReader.Read())
                            {
                                Usuario usuario =  new Usuario();
                                usuario.id = Convert.ToInt32(dataReader["Id"]);
                                usuario.nombre = (string)dataReader["Nombre"];
                                usuario.apellido = (string)dataReader["Apellido"];
                                usuario.NombreUsuario = (string)dataReader["nombreUsuario"];
                                usuario.contrasenia = (string)dataReader["Contraseña"];
                                usuario.mail = (string)dataReader["Mail"];
                                


                                Usuarios.Add(usuario);
                                
                                Console.WriteLine("Nombre:  " + usuario.NombreUsuario);
                                Console.WriteLine("Contaseña: " + usuario.contrasenia);

                            }
                        }
                    }
                }

                return Usuarios;

            }

          

        }
    }

    public class UsuarioHandler : DbHandler
    {
        public List<Usuario> GetUsuario()
        {
            List<Usuario> Usuarios = new List<Usuario>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM usuario", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lista de Usuarios y sus datos :");
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.id = Convert.ToInt32(dataReader["Id"]);
                                usuario.nombre = (string)dataReader["Nombre"];
                                usuario.apellido = (string)dataReader["Apellido"];
                                usuario.NombreUsuario = (string)dataReader["nombreUsuario"];
                                usuario.contrasenia = (string)dataReader["Contraseña"];
                                usuario.mail = (string)dataReader["Mail"];



                                Usuarios.Add(usuario);
                                
                                Console.WriteLine("id: " + usuario.id);
                                Console.WriteLine("Nombre:  " + usuario.nombre);
                                Console.WriteLine("Apellido: " + usuario.apellido);
                                Console.WriteLine("Nombre de Usuario: " + usuario.NombreUsuario);
                                Console.WriteLine("Contaseña: " + usuario.contrasenia);
                                Console.WriteLine("Mail: " + usuario.mail);


                            }
                        }
                    }
                }

                return Usuarios;

            }



        }
    }

    public class ProductoHandler : DbHandler
    {
        public List<Producto> GetProducto()
        {
            List<Producto> Productos = new List<Producto>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                        "SELECT * FROM Producto", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lista de Productos :");
                            while (dataReader.Read())
                            {
                                Producto producto = new Producto();
                                producto.id = Convert.ToInt32(dataReader["Id"]);
                                producto.descripcion = (string)dataReader["Descripciones"];
                                producto.costo = Convert.ToInt32(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(dataReader["precioVenta"]);
                                producto.stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.idUsuario = Convert.ToInt32(dataReader["idUsuario"]);



                                Productos.Add(producto);

                                Console.WriteLine("id: " + producto.id);
                                Console.WriteLine("Nombre:  " + producto.descripcion);
                                Console.WriteLine("Costo: " + producto.costo);
                                Console.WriteLine("Precio Venta: " + producto.PrecioVenta);
                                Console.WriteLine("Stock: " + producto.stock);
                                Console.WriteLine("id Usuario: " + producto.idUsuario);


                            }
                        }
                    }
                }

                return Productos;

            }



        }
}

