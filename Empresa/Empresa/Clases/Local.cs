using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Local
    {
        protected string local_name;
        protected string boss_name;
        protected int id;
        protected string hora_inicio;
        protected string hora_cierre;

        public string Boss_name { get => boss_name; set => boss_name = value; }
        public int Id { get => id; set => id = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_cierre { get => hora_cierre; set => hora_cierre = value; }
        public string Local_name { get => local_name; set => local_name = value; }

        public Local(string name_local, string boss_name, int id, string hora_inicio, string hora_cierre)
        {
            this.Boss_name = boss_name;
            this.Id = id;
            this.Hora_inicio = hora_inicio;
            this.Hora_cierre = hora_cierre;
            this.Local_name = name_local;
        }


    }
}
