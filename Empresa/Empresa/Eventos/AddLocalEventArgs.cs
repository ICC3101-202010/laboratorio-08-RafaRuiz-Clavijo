using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Eventos
{
    public class AddLocalEventArgs : EventArgs
    {
        public string name { get; set; }
        public string boss { get; set; }
        public int id { get; set; }
        public string hora_inicio { get; set; }
        public string hora_final { get; set; }
        public bool mesas { get; set; }
        public int salas { get; set; }
        public List<string> categorias { get; set; }
        public List<string> info_get { get; set; }
    }
}
