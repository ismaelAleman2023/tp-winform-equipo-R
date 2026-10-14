using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public void agregarMarca(Marca nuevoM)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("insert into marcas (Descripcion) values (@Descripcion)");
                datos.setearParametros("@Descripcion", nuevoM.Descripcion_Marca);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Marca> listarMarcas()
        {
            List<Marca> lista_M = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("select id, descripcion from Marcas");
                datos.ejecutarLetura();

                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id_Marca = (int)datos.Lector["id"];
                    marca.Descripcion_Marca = (string)datos.Lector["descripcion"];
                    lista_M.Add(marca);
                }
                return lista_M;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Marca buscarId(int id)
        {
            Marca marca = new Marca();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("select descripcion from marcas where id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarLetura();

                while (datos.Lector.Read())
                {
                    marca.Id_Marca = id;
                    marca.Descripcion_Marca = (string)datos.Lector["descripcion"];
                }
                return marca;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool eliminarMarca(int idMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("delete from Marcas where id = @id");
                datos.setearParametros("@id", idMarca);
                datos.ejecutarAccion();
                return true;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("update Marcas set descripcion = @descripcion where id = @id");
                datos.setearParametros("@descripcion", marca.Descripcion_Marca);
                datos.setearParametros("@id", marca.Id_Marca);
                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool existeMarca(string descripcion, int idExcluir)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("select count(*) from Marcas where LTRIM(RTRIM(Descripcion)) = @descripcion and Id <> @id");
                datos.setearParametros("@descripcion", descripcion.Trim());
                datos.setearParametros("@id", idExcluir);
                datos.ejecutarLetura();

                datos.Lector.Read();
                return datos.Lector.GetInt32(0) > 0;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public bool tieneArticulos(int idMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.consultaSql("select count(*) from ARTICULOS where IdMarca = @id");
                datos.setearParametros("@id", idMarca);
                datos.ejecutarLetura();

                datos.Lector.Read();
                return datos.Lector.GetInt32(0) > 0;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}