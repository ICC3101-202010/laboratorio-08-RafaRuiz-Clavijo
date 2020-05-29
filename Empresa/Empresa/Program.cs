using Empresa.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form appform = new Form1();
            ControladorCine ctrl_cine = new ControladorCine(appform);
            ControladorRecreativa ctrl_recreativa = new ControladorRecreativa(appform);
            ControladorRestaurante ctrl_rest = new ControladorRestaurante(appform);
            ControladorTienda ctrl_tienda = new ControladorTienda(appform);
            Application.Run(appform);
        }
    }
}
