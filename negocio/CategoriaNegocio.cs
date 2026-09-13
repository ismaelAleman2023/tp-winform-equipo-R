using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> lista() {

            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {


                datos.consultaSql("select descripcion from CATEGORIAS");

                datos.ejecutarLetura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Descripcion_Categoria = (string)datos.Lector["descripcion"];
                    listaCategoria.Add(aux);

                }


                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                datos.cerrarConexion();
            }








        }

        public void agregarCategoria(Categoria nuevoC) {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.consultaSql("insert into CATEGORIAS (descripcion) values(@descripcion)");
                datos.setearParametros("@descripcion", nuevoC.Descripcion_Categoria);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }


        }

        public bool eliminarCategoria(int idCategoria) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("delete from CATEGORIAS where Id = @id");
                datos.setearParametros("@id", idCategoria);
                datos.ejecutarAccion();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally { datos.cerrarConexion(); }



        }

        public Categoria buscarIdCategoria(int idCategoria) {

            AccesoDatos datos = new AccesoDatos();
            Categoria categoria = new Categoria();

            try
            {
                datos.consultaSql("select descripcion from CATEGORIAS where id=@id");
                datos.setearParametros("@id", idCategoria);

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id_Categoria = idCategoria;
                    aux.Descripcion_Categoria = (string)datos.Lector["descripcion"];


                }
                return categoria;
            }
            catch (Exception ex)
            {

                throw ex;
            } finally { datos.cerrarConexion(); }

        }

        public void modificarCategoria(Categoria cate) {
            AccesoDatos datos= new AccesoDatos();    
            
            
            try
            {
                datos.consultaSql("update CATEGORIAS set Descripcion=@Descripcion where id=@id");
                datos.setearParametros("@descepcion",cate.Descripcion_Categoria);
                datos.setearParametros("@id",cate.Id_Categoria);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        
        }



    }
}

