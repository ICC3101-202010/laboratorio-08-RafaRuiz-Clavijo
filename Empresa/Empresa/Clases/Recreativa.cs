using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Recreativa : Local
    {
        public Recreativa(string boss_name, int id, string hora_inicio, string hora_cierre): base(boss_name,
            id, hora_inicio, hora_cierre)
        {

        }
    }
}
