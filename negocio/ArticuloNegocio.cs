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
                datos.consultaSql("INSERT INTO dbo.ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ('"+ articulo.Codigo_Articulo + "', '"+ articulo.Nombre_Articulo + "', '"+ articulo.Descripcion_Articulo + "', "+ articulo.IdMarca_Articulo + ", "+ articulo.Categoria_Articulo + ", "+ articulo.Precio_Articulo + ")");

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

                    auxiliar.Codigo_Articulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre_Articulo = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion_Articulo = (string)datos.Lector["Descripcion"];
                    auxiliar.IdMarca_Articulo = (int)datos.Lector["IdMarca"];
                    auxiliar.Categoria_Articulo = (int)datos.Lector["IdCategoria"];
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
    }
}