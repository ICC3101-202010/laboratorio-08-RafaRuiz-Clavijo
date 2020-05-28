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
    public class ControladorCine
    {
        List<Cine> cines = new List<Cine>();
        Form1 appform;

        public ControladorCine(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddCine += OnAddCine;
        }

        public void OnAddCine(object sender, AddLocalEventArgs e)
        {
            cines.Add(new Cine(e.salas, e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
        }
    }
}
