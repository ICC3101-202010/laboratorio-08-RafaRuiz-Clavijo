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
            this.appform.OnClickTienda += OnClickTienda;
        }

        public void OnAddTienda(object source, AddLocalEventArgs e)
        {
            tienda.Add(new Tienda(e.categorias, e.boss, e.id, e.hora_inicio, e.hora_final, e.name));
            e.info_get.Add(e.name);
        }

        public void OnClickTienda(object sender, AddLocalEventArgs e)
        {
            string local_name = "";
            string local_boss = "";
            int local_id = 0; ;
            string local_hi = "";
            string local_hf = "";
            List<string> categorias = new List<string>();
            foreach (Tienda data in tienda)
            {
                if (data.Local_name == e.name)
                {
                    local_name = data.Local_name;
                    local_boss = data.Boss_name;
                    local_hf = data.Hora_cierre;
                    local_hi = data.Hora_inicio;
                    local_id = data.Id;
                    categorias = data.Categorias;
                }
            }
            appform.Show_Info_Local(local_name, local_boss, local_id, local_hi, local_hf, categorias, true, -1, -1);
        }
    }
}
