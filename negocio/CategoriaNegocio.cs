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
        
        List<Categoria> listaCategoria=new List<Categoria>();
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


    }
}
