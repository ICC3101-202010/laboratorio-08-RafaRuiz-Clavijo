using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Clases
{
    public class Cine : Local
    {
        private int numero_salas;

        public Cine(int numero_salas, string boss_name, int id, string hora_inicio, string hora_cierre, string nombre) : base(nombre, boss_name,
            id, hora_inicio, hora_cierre)
        {
            this.Numero_salas = numero_salas;
        }

        public int Numero_salas { get => numero_salas; set => numero_salas = value; }
    }
}
