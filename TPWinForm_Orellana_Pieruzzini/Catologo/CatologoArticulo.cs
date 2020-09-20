using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Catologo
{
    public class CatologoArticulo
    {
        //private CatologoArticulo p = new CatologoArticulo();
        private const string V = "select distinct P.Id, P.Codigo, P.Nombre, P.Descripcion, P.ImagenUrl, P.Precio, D.Id,D.Descripcion, C.Id,C.Descripcion  from ARTICULOS P Left join CATEGORIAS C on C.Id = P.IdCategoria inner join MARCAS D  on D.Id = P.IdMarca order by P.Id asc";

        public List<Articulos> Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();

            try 
            {
                conexion.ConnectionString = "data source=DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = V;
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.idArticulo = lector.GetInt32(0);
                    aux.Codigo = lector.GetString(1);
                    aux.Nombre = lector.GetString(2);
                    aux.Descripcion = lector.GetString(3);

                    aux.Marca = new Marcas();
                    aux.Marca.idMarca = lector.GetInt32(6);
                    aux.Marca.DescripcionMarca = lector.GetString(7);

                    aux.categoria = new Categoria();
                    //aux.categoria.idCategoria = lector.GetInt32(8);//error
                    aux.categoria.DescripcionCategoria = (string)lector["descripcion"];
                   
                    aux.Precio = lector.GetDecimal(5);
                    aux.Imagen = (string)lector["ImagenUrl"];

                    lista.Add(aux);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conexion.Close();
            return lista;

        }

        private string ArgumentNullException(string descripcionCategoria)
        {
            throw new NotImplementedException();
        }

        public List<Marcas> ListarMarca()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Marcas> lista = new List<Marcas>();

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion from MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.idMarca = lector.GetInt32(0);
                    aux.DescripcionMarca = lector.GetString(1);
                    lista.Add(aux);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            conexion.Close();
            return lista;
        }

        public List<Categoria> ListarCategoria()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Categoria> lista = new List<Categoria>();

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Descripcion from CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.idCategoria = lector.GetInt32(0);
                    aux.DescripcionCategoria = lector.GetString(1);
                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conexion.Close();
            return lista;
        }

        public void Eliminar(string codigo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try 
            {
                conexion.ConnectionString = "data source= DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();

                comando.CommandText = "Delete ARTICULOS WHERE Codigo=@codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }

        public void Agregar(Articulos articulos)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "data source= DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();

                comando.CommandText = "insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
                // comando.Parameters.AddWithValue("@Id", articulos.idArticulo);
                comando.Parameters.AddWithValue("@Codigo", articulos.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulos.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulos.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulos.Marca.idMarca);
                comando.Parameters.AddWithValue("@IdCategoria", articulos.categoria.idCategoria);
                comando.Parameters.AddWithValue("@ImagenUrl", articulos.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulos.Precio);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
      
        public void Editar(Articulos articulos)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            
            
            try
            {
                conexion.ConnectionString = "data source= DESKTOP-GPR5PDL\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();

                comando.CommandText = ("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Codigo=@Codigo ;");
                comando.Parameters.AddWithValue("@Id", articulos.idArticulo);
                comando.Parameters.AddWithValue("@Codigo",articulos.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulos.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulos.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulos.Marca.idMarca);
                comando.Parameters.AddWithValue("@IdCategoria", articulos.categoria.idCategoria);
                comando.Parameters.AddWithValue("@ImagenUrl", articulos.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulos.Precio);

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
    }
     

}
