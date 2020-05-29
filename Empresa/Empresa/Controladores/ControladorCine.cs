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
            this.appform.OnClickCine += OnClickCine;
        }

        public void OnAddCine(object sender, AddLocalEventArgs e)
        {
            cines.Add(new Cine(e.salas, e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
            e.info_get.Add(e.name);
        }
        public void OnClickCine(object sender, AddLocalEventArgs e)
        {
            string local_name = "";
            string local_boss = "";
            int local_id = 0; ;
            string local_hi = "";
            string local_hf = "";
            int salas = 0;
            foreach (Cine data in cines)
            {
                if (data.Local_name == e.name)
                {
                    local_name = data.Local_name;
                    local_boss = data.Boss_name;
                    local_hf = data.Hora_cierre;
                    local_hi = data.Hora_inicio;
                    local_id = data.Id;
                    salas = data.Numero_salas;
                }
            }
            appform.Show_Info_Local(local_name, local_boss, local_id, local_hi, local_hf, new List<string>(), true,-1, salas);
        }
    }
}
