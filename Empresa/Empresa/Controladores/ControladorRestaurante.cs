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
    public class ControladorRestaurante
    {
        List<Restaurante> restaurantes = new List<Restaurante>();
        Form1 appform;

        public ControladorRestaurante(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddRestaurante += OnAddRestaurante;
        }

        public void OnAddRestaurante(object sender, AddLocalEventArgs e)
        {
            restaurantes.Add(new Restaurante(e.mesas, e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
        }
    }
}
