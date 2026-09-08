using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Diagnostics;


namespace TPWinForm_equipo_R
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Articulo articulo = new Articulo();
            articulo.Codigo_Articulo = "1";
            articulo.Nombre_Articulo = "pepe";
            articulo.Descripcion_Articulo = "fff";
            articulo.IdMarca_Articulo = 1;
            articulo.Precio_Articulo = 1;
            articulo.Categoria_Articulo = 2;
            Debug.WriteLine(articulo.ToString());
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articuloNegocio.alta(articulo);
            articuloNegocio.listar();
           
        }
    }
}
