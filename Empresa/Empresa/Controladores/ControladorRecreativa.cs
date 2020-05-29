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
            this.appform.OnClickRecreativa += OnClickRecreativa;
        }

        public void OnAddRecreativa(object sender, AddLocalEventArgs e)
        {
            recreativa.Add(new Recreativa(e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
            e.info_get.Add(e.name);
        }

        public void OnClickRecreativa(object sender, AddLocalEventArgs e)
        {
            string local_name = "";
            string local_boss = "";
            int local_id = 0; ;
            string local_hi = "";
            string local_hf = "";
            foreach (Recreativa data in recreativa)
            {
                if (data.Local_name == e.name)
                {
                    local_name = data.Local_name;
                    local_boss = data.Boss_name;
                    local_hf = data.Hora_cierre;
                    local_hi = data.Hora_inicio;
                    local_id = data.Id;
                }
            }
            appform.Show_Info_Local(local_name, local_boss, local_id, local_hi, local_hf, new List<string>(), true,-1, -1);
        }
    }
}
