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
        private List<Articulo> articulos = new List<Articulo>();

        public void alta(Articulo articulo)
        {
            this.articulos.Add(articulo);
        }
        public void listar()
        {
            foreach (var articulo in this.articulos)
            {
                Debug.WriteLine(articulo);
            }
        }
    }
}

