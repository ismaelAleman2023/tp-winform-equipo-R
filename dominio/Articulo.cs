using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public Articulo() { }

        public string Codigo_Articulo {  get; set; }
        public string Nombre_Articulo {  get; set; }
        public string Descripcion_Articulo {  get; set; }
        public int IdMarca_Articulo { get; set; }
        public int Categoria_Articulo {  get; set; }
        public double Precio_Articulo { get; set; }

    }

}
