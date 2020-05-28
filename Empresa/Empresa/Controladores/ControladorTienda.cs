using Empresa.Clases;
using Empresa.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.Controladores
{
    public class ControladorTienda
    {
        List<Tienda> tienda = new List<Tienda>();
        Form1 appform;

        public ControladorTienda(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddTienda += OnAddTienda;
        }

        public void OnAddTienda(object source, AddLocalEventArgs e)
        {
            tienda.Add(new Tienda(e.categorias, e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
        }
    }
}
