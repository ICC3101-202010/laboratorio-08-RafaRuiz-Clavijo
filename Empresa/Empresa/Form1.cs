using Empresa.Eventos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Form1 : Form
    {
        public delegate void AddLocalEventHandler(object source, AddLocalEventArgs args);
        public event AddLocalEventHandler AddTienda;
        public event AddLocalEventHandler AddCine;
        public event AddLocalEventHandler AddRestaurante;
        public event AddLocalEventHandler AddRecreativa;

        public Form1()
        {
            InitializeComponent();
        }

        private void label_add_cine_Click(object sender, EventArgs e)
        {
            string name_local = textBox_nombre_cine.Text;
            int id_local = 0;
            int.TryParse(textBox_id_cine.Text, out id_local);
            string boss_name = textBox_boss_cine.Text;
            string hora_inicio = textBox_hora_inicio_cine.Text;
            string hora_final = textBox_hora_final_cine.Text;
            int numero_salas = 0;
            int.TryParse(textBox_id_cine.Text, out numero_salas);
            AddCine(this, new AddLocalEventArgs()
            {
                boss = boss_name,
                hora_final = hora_final,
                hora_inicio = hora_inicio,
                id = id_local,
                name = name_local,
                salas = numero_salas
            });
        }

        private void label_add_tienda_Click(object sender, EventArgs e)
        {
            string name_local = textBox_nombre_tienda.Text;
            int id_local = 0;
            int.TryParse(textBox_id_tienda.Text, out id_local);
            string boss_name = textBox_boss_tienda.Text;
            string hora_inicio = textBox_hora_inicio_tienda.Text;
            string hora_final = textBox_hora_final_tienda.Text;
            List<string> categorias = textBox_categoria_tiendas.Text.Split(',').ToList();
            AddTienda(this, new AddLocalEventArgs()
            {
                boss = boss_name,
                hora_final = hora_final,
                hora_inicio = hora_inicio,
                id = id_local,
                name = name_local,
                categorias = categorias
            }) ;
        }

        private void label_agregar_local_Click(object sender, EventArgs e)
        {

        }

        private void button_add_restaurante_Click(object sender, EventArgs e)
        {
            string name_local = textBox_nombre_restaurante.Text;
            int id_local = 0;
            int.TryParse(textBox_id_restaurante.Text, out id_local);
            string boss_name = textBox_boss_restaurante.Text;
            string hora_inicio = textBox_hora_inicio_restaurante.Text;
            string hora_final = textBox_hora_final_restaurante.Text;
            bool private_mesas = checkBox_mesas_privadas_restaurante.Checked;
            AddRestaurante(this, new AddLocalEventArgs()
            {
                boss = boss_name,
                hora_final = hora_final,
                hora_inicio = hora_inicio,
                id = id_local,
                name = name_local,
                mesas = private_mesas
            }) ;
        }

        private void button_agregar_recreativa_Click(object sender, EventArgs e)
        {
            string name_local = textBox_nombre_recreativa.Text;
            int id_local = 0;
            int.TryParse(textBox_id_recreativa.Text, out id_local);
            string boss_name = textBox_boss_recreativa.Text;
            string hora_inicio = textBox_hora_inicio_recreativa.Text;
            string hora_final = textBox_hora_final_recreativa.Text;
            AddRecreativa(this, new AddLocalEventArgs()
            {
                boss = boss_name,
                hora_final = hora_final,
                hora_inicio = hora_inicio,
                id = id_local,
                name = name_local,
            });
        }
    }
}
