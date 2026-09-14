using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Diagnostics;

namespace negocio
{
    public class ArticuloNegocio
    {
        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.consultaSql("INSERT INTO dbo.ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('"+ articulo.Codigo_Articulo + "', '"+ articulo.Nombre_Articulo + "', '"+ articulo.Descripcion_Articulo + "', "+ articulo.Marca_Articulo.Id_Marca + ", "+ articulo.Categoria_Articulo.Id_Categoria + ", "+ articulo.Precio_Articulo + ")");

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> Listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.consultaSql("select * from dbo.ARTICULOS");
                datos.ejecutarLetura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Marca_Articulo = new Marca();
                    auxiliar.Categoria_Articulo = new Categoria();
                  

                    auxiliar.Codigo_Articulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre_Articulo = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion_Articulo = (string)datos.Lector["Descripcion"];
                    auxiliar.Marca_Articulo.Id_Marca = (int)datos.Lector["IdMarca"];
                    auxiliar.Categoria_Articulo.Id_Categoria = (int)datos.Lector["IdCategoria"];
                    auxiliar.Precio_Articulo = (float)datos.Lector["Precio"];

                    articulos.Add(auxiliar);
                }

                return articulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("delete from dbo.ARTICULOS where Id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
           
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("UPDATE dbo.ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");
                datos.setearParametros("@Codigo", articulo.Codigo_Articulo);
                datos.setearParametros("@Nombre", articulo.Nombre_Articulo);
                datos.setearParametros("@Descripcion", articulo.Descripcion_Articulo);
                datos.setearParametros("@IdMarca", articulo.Marca_Articulo.Id_Marca); 
                datos.setearParametros("@IdCategoria", articulo.Categoria_Articulo.Id_Categoria);
                datos.setearParametros("@Precio", articulo.Precio_Articulo);
                datos.setearParametros("@Id", articulo.Id_Articulo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}