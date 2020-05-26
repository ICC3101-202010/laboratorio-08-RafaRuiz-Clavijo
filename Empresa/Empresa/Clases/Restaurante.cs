using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Restaurante : Local
    {
        private bool mesas_exclusivas;

        public Restaurante(bool mesas_exclusivas, string boss_name, int id, string hora_inicio, string hora_cierre, string nombre) : base(nombre, boss_name,
            id, hora_inicio, hora_cierre)
        {
            this.mesas_exclusivas = mesas_exclusivas;
        }

        public bool Mesas_exclusivas { get => mesas_exclusivas; set => mesas_exclusivas = value; }
    }
}
