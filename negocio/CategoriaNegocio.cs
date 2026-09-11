using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> lista() {

            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos dato = new AccesoDatos();

            try
            {


                dato.consultaSql("select descripcion from CATEGORIAS");

                dato.ejecutarLetura();

                while (dato.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Descripcion_Categoria = (string)dato.Lector["descripcion"];
                    listaCategoria.Add(aux);

                }


                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                dato.cerrarConexion();
            }








        }

        public void agregarCategoria(Categoria nuevoC) { 
        
            AccesoDatos dato=new AccesoDatos();

            try
            {
                dato.consultaSql("insert into CATEGORIAS (descripcion) values(@descripcion)");
                dato.setearParametros("@descripcion", nuevoC.Descripcion_Categoria);
                dato.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { dato.cerrarConexion(); }
        
        
        }

        public bool eliminarCategoria(int idCategoria) { 
         
         AccesoDatos dato =new AccesoDatos();
            try
            {
                dato.consultaSql("delete from CATEGORIAS where Id = @id");
                dato.setearParametros("@id", idCategoria);
                dato.ejecutarAccion();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
                
            }
            finally { dato.cerrarConexion(); }
        
        
        
        }






    }
}
