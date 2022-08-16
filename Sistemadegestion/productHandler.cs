
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

                                ProductoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                ProductoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                ProductoVendido.IdProducto = Convert.ToInt32(dataReader["idProducto"]);
                                ProductoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);


                                ProdVendido.Add(ProductoVendido);

                                Console.WriteLine("Id:  " + ProductoVendido.Id);
                                Console.WriteLine("Stock" + ProductoVendido.Stock);
                                Console.WriteLine("IdProducto" + ProductoVendido.IdProducto);
                                Console.WriteLine("IdVenta" + ProductoVendido.IdVenta);
                            }


                            }
                        }
                    }
                }

                return ProdVendido;

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
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = (string)dataReader["Nombre"];
                                usuario.Apellido = (string)dataReader["Apellido"];
                                usuario.NombreUsuario = (string)dataReader["nombreUsuario"];
                                usuario.Contrasenia = (string)dataReader["Contraseña"];
                                usuario.Mail = (string)dataReader["Mail"];
                                


                                Usuarios.Add(usuario);
                                
                                Console.WriteLine("Nombre:  " + usuario.NombreUsuario);
                                Console.WriteLine("Contaseña: " + usuario.Contrasenia);

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
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = (string)dataReader["Nombre"];
                                usuario.Apellido = (string)dataReader["Apellido"];
                                usuario.NombreUsuario = (string)dataReader["nombreUsuario"];
                                usuario.Contrasenia = (string)dataReader["Contraseña"];
                                usuario.Mail = (string)dataReader["Mail"];



                                Usuarios.Add(usuario);
                                
                                Console.WriteLine("id: " + usuario.Id);
                                Console.WriteLine("Nombre:  " + usuario.Nombre);
                                Console.WriteLine("Apellido: " + usuario.Apellido);
                                Console.WriteLine("Nombre de Usuario: " + usuario.NombreUsuario);
                                Console.WriteLine("Contaseña: " + usuario.Contrasenia);
                                Console.WriteLine("Mail: " + usuario.Mail);


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
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = (string)dataReader["Descripciones"];
                                producto.Costo = Convert.ToInt32(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(dataReader["precioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["idUsuario"]);



                                Productos.Add(producto);

                                Console.WriteLine("id: " + producto.Id);
                                Console.WriteLine("Nombre:  " + producto.Descripcion);
                                Console.WriteLine("Costo: " + producto.Costo);
                                Console.WriteLine("Precio Venta: " + producto.PrecioVenta);
                                Console.WriteLine("Stock: " + producto.Stock);
                                Console.WriteLine("id Usuario: " + producto.IdUsuario);


                            }
                        }
                    }
                }

                return Productos;

            }



        }
}

    public class UsuarioParametroHandler : DbHandler
    {
       
        public void TraerUsuario()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using(SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario WHERE Nombre = @nombreUsuario", sqlConnection))
                {

                    String nombreUsuario = "Gaston";
                    sqlConnection.Open();
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "nombreUsuario";
                    parametro.Value = nombreUsuario;
                    sqlCommand.Parameters.Add(parametro);

                    
                    
                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Los datos del Usuario son: ");
                            while (reader.Read())
                            {
                                Usuario usuario2 = new Usuario();
                                usuario2.Id = Convert.ToInt32(reader["Id"]);
                                usuario2.Nombre = (string)reader["Nombre"];
                                usuario2.Apellido = (string)reader["Apellido"];
                                usuario2.Mail = (string)reader["Mail"];
                                usuario2.NombreUsuario = (string)reader["nombreUsuario"];
                                usuario2.Contrasenia = (string)reader["Contraseña"];

                                Console.WriteLine("El nombre es: " + usuario2.Nombre);
                                Console.WriteLine("El apellido es: " + usuario2.Apellido);
                                Console.WriteLine("El nombre de usuario es: " + usuario2.NombreUsuario);
                                Console.WriteLine("El mail es: " + usuario2.Mail);
                                Console.WriteLine("Su contraseña es: " + usuario2.Contrasenia);
                                Console.WriteLine("Su ID es: " + usuario2.Id);
                            }
                        }
                    }



                    sqlConnection.Close();


                }
            }
        }
    }

    public class productoUsuario : DbHandler
    {

        public List<Producto> TraerProducto()
        {

            List<Producto> ProductoXUsuario = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Producto p, Usuario u WHERE p.IdUsuario = u.Id AND u.Id = @IdUsuario", sqlConnection))
                {

                    int IdUsuario = 1;
                    sqlConnection.Open();
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.Value = IdUsuario;
                    sqlCommand.Parameters.Add(parametro);



                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lista de Productos cargados por el Usuario :");
                            while (reader.Read())
                            {
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(reader["Id"]);
                                producto.Descripcion = (string)reader["Descripciones"];
                                producto.Costo = Convert.ToInt32(reader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(reader["precioVenta"]);
                                producto.Stock = Convert.ToInt32(reader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(reader["idUsuario"]);



                                ProductoXUsuario.Add(producto);

                                Console.WriteLine("id: " + producto.Id);
                                Console.WriteLine("Nombre:  " + producto.Descripcion);
                                Console.WriteLine("Costo: " + producto.Costo);
                                Console.WriteLine("Precio Venta: " + producto.PrecioVenta);
                                Console.WriteLine("Stock: " + producto.Stock);
                                Console.WriteLine("id Usuario: " + producto.IdUsuario);


                            }
                        }
                    }



                    sqlConnection.Close();


                }
            }

            return ProductoXUsuario;
        }
    }

    public class UsuarioYcontraseña : DbHandler
    {

        public void InicioDeSesion()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario WHERE NombreUsuario = @nombreUsuario AND Contraseña = @contraseña", sqlConnection))
                {

                    String nombreUsuario = "GastonCODERHOUSE";
                    String contraseña = "lilo";
                    sqlConnection.Open();
                    SqlParameter parametro = new SqlParameter();
                    SqlParameter clave = new SqlParameter();
                    parametro.ParameterName = "nombreUsuario";
                    clave.ParameterName = "contraseña";
                    parametro.Value = nombreUsuario;
                    clave.Value = contraseña;
                    sqlCommand.Parameters.Add(clave);
                    sqlCommand.Parameters.Add(parametro);



                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("El usuario existe y sus datos son:");
                            while (reader.Read())
                            {
                                Usuario usuario2 = new Usuario();
                                usuario2.Id = Convert.ToInt32(reader["Id"]);
                                usuario2.Nombre = (string)reader["Nombre"];
                                usuario2.Apellido = (string)reader["Apellido"];
                                usuario2.Mail = (string)reader["Mail"];
                                usuario2.NombreUsuario = (string)reader["nombreUsuario"];
                                usuario2.Contrasenia = (string)reader["Contraseña"];

                                
                                
                                Console.WriteLine("El nombre es: " + usuario2.Nombre);
                                Console.WriteLine("El apellido es: " + usuario2.Apellido);
                                Console.WriteLine("El nombre de usuario es: " + usuario2.NombreUsuario);
                                Console.WriteLine("El mail es: " + usuario2.Mail);
                                Console.WriteLine("Su contraseña es: " + usuario2.Contrasenia);
                                Console.WriteLine("Su ID es: " + usuario2.Id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe ningun usuario con ese nombre");
                        }
                    }



                    sqlConnection.Close();


                }
            }
        }
    }

    public class UsuarioVentas : DbHandler
    {

        public List<Producto> TraerProductosVendidos()
        {
            List<Producto> ProductoVendido = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "Select pv.Id, p.Descripciones, p.Costo, p.PrecioVenta, p.Stock, u.Id FROM ProductoVendido pv JOIN Producto p ON pv.IdProducto = p.Id JOIN Usuario u ON u.Id = p.IdUsuario WHERE u.Id = @idUsuario "
, sqlConnection))
                {

                    int idUsuario = 1;
                    
                    sqlConnection.Open();
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "idUsuario";
                    parametro.Value = idUsuario;
                    sqlCommand.Parameters.Add(parametro);



                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Los productos y sus datos son:");
                            while (reader.Read())
                            {
                                Producto ProductoVendidoXUsuario = new Producto();
                                ProductoVendidoXUsuario.Id = Convert.ToInt32(reader["Id"]);
                                ProductoVendidoXUsuario.Descripcion = (string)reader["Descripciones"];
                                ProductoVendidoXUsuario.Costo = Convert.ToInt32(reader["Costo"]);
                                ProductoVendidoXUsuario.PrecioVenta = Convert.ToInt32(reader["PrecioVenta"]);
                                ProductoVendidoXUsuario.Stock = Convert.ToInt32(reader["Stock"]);
                                ProductoVendidoXUsuario.IdUsuario = Convert.ToInt32(reader["Id"]);


                                ProductoVendido.Add(ProductoVendidoXUsuario);

                                Console.WriteLine("El nombre es: " + ProductoVendidoXUsuario.Descripcion);
                                Console.WriteLine("El costo es: " + ProductoVendidoXUsuario.Costo);
                                Console.WriteLine("El precio de venta es: " + ProductoVendidoXUsuario.PrecioVenta);
                                Console.WriteLine("El stock es: " + ProductoVendidoXUsuario.Stock);
                                Console.WriteLine("El id del usuario es: " + ProductoVendidoXUsuario.IdUsuario);
                                Console.WriteLine("Su ID es: " + ProductoVendidoXUsuario.Id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe ningun usuario con ese nombre");
                        }
                    }



                    sqlConnection.Close();


                }
            }

            return ProductoVendido;
        }
    }
}



