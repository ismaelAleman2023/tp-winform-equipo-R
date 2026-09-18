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
      
        static void Main()
        {

          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new FrmAdminPrincipal());

            

        }
    }
}
