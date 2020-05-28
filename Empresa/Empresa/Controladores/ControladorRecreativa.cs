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
    public class ControladorRecreativa
    {
        List<Recreativa> recreativa = new List<Recreativa>();
        Form1 appform;

        public ControladorRecreativa(Form appform)
        {
            this.appform = appform as Form1;
            this.appform.AddRecreativa += OnAddRecreativa;
        }

        public void OnAddRecreativa(object sender, AddLocalEventArgs e)
        {
            recreativa.Add(new Recreativa(e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
        }
    }
}
