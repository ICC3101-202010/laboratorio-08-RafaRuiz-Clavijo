using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Tienda : Local
    {
        private List<string> categorias;

        public Tienda(List<string> categorias, string boss_name, int id, string hora_inicio, string hora_cierre, string nombre) : base (nombre, boss_name,
            id, hora_inicio, hora_cierre)
        {
            this.Categorias = categorias;
        }

        public List<string> Categorias { get => categorias; set => categorias = value; }
    }
}
