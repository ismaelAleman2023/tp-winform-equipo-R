using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    internal class ImagenNegocio
    {
        
     public void agregarImagen(Imagen img)
     {
            AccesoDatos datos= new AccesoDatos();

            try
            {
                datos.consultaSql("insert into Imagenes(idArticulo,ImagenUrl) select (@idArt, @imagen)");
                datos.setearParametros("@idArt", img.IdArticulo_Imagen);
                datos.setearParametros("@imagen", img.Url_Imagen);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {datos.cerrarConexion(); }
     }

        public void eliminarImagen(int idArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.consultaSql("delete from imagenes where IdArticulo = @idart");
                datos.setearParametros("@idart", idArt);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {  datos.cerrarConexion(); }
        }

        public Imagen BuscarImagenId (int idImagen)
        {

            AccesoDatos datos = new AccesoDatos();
            Imagen img = new Imagen();
            try
            {
                datos.consultaSql("select id, idArticulo, imagenUrl from Imagenes where id = @id");
                datos.setearParametros("@id", idImagen);
                datos.ejecutarLetura();

                if(datos.Lector.Read())
                {
                    img.Id_Imangen = (int)datos.Lector["id"];
                    img.IdArticulo_Imagen = (int) datos.Lector["idArticulo"];
                    img.Url_Imagen= (string) datos.Lector["imagenUrl"];

                }
                
                return img;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }           

        }


        public void modificarImagen(string url, int idImagen)
        {
            AccesoDatos datos=new AccesoDatos();

            try
            {
                datos.consultaSql("update Imagen set imagenUrl = @urlImagen");
                datos.setearParametros("@rlImagen", url);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{ datos.cerrarConexion(); };


        }


    }
}
