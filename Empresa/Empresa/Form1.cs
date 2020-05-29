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

        public event AddLocalEventHandler OnClickTienda;
        public event AddLocalEventHandler OnClickCine;
        public event AddLocalEventHandler OnClickRestaurante;
        public event AddLocalEventHandler OnClickRecreativa;

        List<Label> locales = new List<Label>();

        List<string> tiendas = new List<string>();
        List<string> cines = new List<string>();
        List<string> restaurantes = new List<string>();
        List<string> recreativas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label_add_cine_Click(object sender, EventArgs e)
        {
            panel_info_local.Visible = true;
            panel_ver_info_locales.Visible = true;
            panel_tienda.Visible = true;
            panel_cine.Visible = true;
        }

        private void label_add_tienda_Click(object sender, EventArgs e)
        {
            panel_info_local.Visible = true;
            panel_ver_info_locales.Visible = true;
            panel_tienda.Visible = true;
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
                mesas = private_mesas,
                info_get = restaurantes              
            }) ;
            textBox_nombre_restaurante.ResetText();
            textBox_id_restaurante.ResetText();
            textBox_boss_restaurante.ResetText();
            textBox_hora_inicio_restaurante.ResetText();
            textBox_hora_final_restaurante.ResetText();
            checkBox_mesas_privadas_restaurante.Checked = false;
            OnShowInfo(tiendas, cines, restaurantes, recreativas);
            OnBack();
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
                info_get = recreativas
            }) ;
            textBox_nombre_recreativa.ResetText();
            textBox_id_recreativa.ResetText();
            textBox_boss_recreativa.ResetText();
            textBox_hora_inicio_recreativa.ResetText();
            textBox_hora_final_recreativa.ResetText();
            OnShowInfo(tiendas, cines, restaurantes, recreativas);
            OnBack();
        }

        private void button_atras_recreativa_Click(object sender, EventArgs e)
        {
            OnBack();
        }

        private void button_atras_restaurante_Click(object sender, EventArgs e)
        {
            OnBack();
        }

        private void button_Atras_ver_info_Click(object sender, EventArgs e)
        {
            panel_info_local.Controls.Clear();
            OnBack();
        }

        private void button_back_tienda_Click(object sender, EventArgs e)
        {
            OnBack();
        }

        private void button_atras_cine_Click(object sender, EventArgs e)
        {
            OnBack();
        }

        public void OnBack()
        {
            panel_agregar_recreativa.Visible = false;
            panel_agregar_Restaurante.Visible = false;
            panel_cine.Visible = false;
            panel_tienda.Visible = false;
            panel_ver_info_locales.Visible = false;
            panel_info_local.Visible = false;
        }

        public void OnShowInfo(List<string> tiendas, List<string> cines, List<string> restaurantes, List<string> recreativas)
        {
            for(int i = 0; i < locales.Count(); i++)
            {
                panel_ver_wandes.Controls.Remove(locales[i]);
            }
            locales.Clear();
            int pos_x = 25;
            int pos_y = 15;
            foreach(string data in tiendas)
            {
                Label tienda = Add_Label(data, pos_x, pos_y);
                panel_ver_wandes.Controls.Add(tienda);
                tienda.Click += new System.EventHandler(this.ClickTienda);
                locales.Add(tienda);
                pos_y += 30;
            }
            foreach (string data in cines)
            {
                Label cine = Add_Label(data, pos_x, pos_y);
                panel_ver_wandes.Controls.Add(cine);
                cine.Click += new System.EventHandler(this.ClickCine);
                locales.Add(cine);
                pos_y += 30;
            }
            foreach (string data in restaurantes)
            {
                Label restaurant = Add_Label(data, pos_x, pos_y);
                panel_ver_wandes.Controls.Add(restaurant);
                restaurant.Click += new System.EventHandler(this.ClickRestaurant);
                locales.Add(restaurant);
                pos_y += 30;
            }
            foreach (string data in recreativas)
            {
                Label recreativa = Add_Label(data, pos_x, pos_y);
                panel_ver_wandes.Controls.Add(recreativa);
                recreativa.Click += new System.EventHandler(this.ClickRecreativa);
                locales.Add(recreativa);
                pos_y += 30;
            }
        }

        private void label_add_restaurant_Click(object sender, EventArgs e)
        {
            
        }

        private void label_add_recreativa_Click(object sender, EventArgs e)
        {

        }

        private void button_add_cine_Click(object sender, EventArgs e)
        {
            string name_local = textBox_nombre_cine.Text;
            int id_local = 0;
            int.TryParse(textBox_id_cine.Text, out id_local);
            string boss_name = textBox_boss_cine.Text;
            string hora_inicio = textBox_hora_inicio_cine.Text;
            string hora_final = textBox_hora_final_cine.Text;
            int numero_salas = 0;
            int.TryParse(textBox_salas_cine.Text, out numero_salas);
            AddCine(this, new AddLocalEventArgs()
            {
                boss = boss_name,
                hora_final = hora_final,
                hora_inicio = hora_inicio,
                id = id_local,
                name = name_local,
                salas = numero_salas,
                info_get = cines
            });
            textBox_nombre_cine.ResetText();
            textBox_id_cine.ResetText();
            textBox_boss_cine.ResetText();
            textBox_hora_inicio_cine.ResetText();
            textBox_hora_final_cine.ResetText();
            textBox_salas_cine.ResetText();
            OnShowInfo(tiendas, cines, restaurantes, recreativas);
            OnBack();
        }

        private void button_agregar_tienda_Click(object sender, EventArgs e)
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
                categorias = categorias,
                info_get = tiendas
            });
            textBox_nombre_tienda.ResetText();
            textBox_id_tienda.ResetText();
            textBox_boss_tienda.ResetText();
            textBox_hora_inicio_tienda.ResetText();
            textBox_hora_final_tienda.ResetText();
            textBox_categoria_tiendas.ResetText();
            OnShowInfo(tiendas, cines, restaurantes, recreativas);
            OnBack();
        }

        private void label_restaurante_Click(object sender, EventArgs e)
        {
            panel_info_local.Visible = true;
            panel_ver_info_locales.Visible = true;
            panel_tienda.Visible = true;
            panel_cine.Visible = true;
            panel_agregar_Restaurante.Visible = true;
        }

        private void label_recreativa_Click(object sender, EventArgs e)
        {
            panel_info_local.Visible = true;
            panel_ver_info_locales.Visible = true;
            panel_tienda.Visible = true;
            panel_cine.Visible = true;
            panel_agregar_Restaurante.Visible = true;
            panel_agregar_recreativa.Visible = true;
        }

        public Label Add_Label(string nombre, int x, int y)
        {
            Label label = new Label();
            label.Name = "label_" + nombre;
            label.Text = nombre;
            label.Width = 450;
            label.ForeColor = Color.Black;
            label.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);
            label.Location = new Point(x, y);
            return label;
        }

        public void ClickTienda(object sender, EventArgs e)
        {
            Label currentable = (Label)sender;
            string name = currentable.Name.Remove(0, 6);
            OnClickTienda(this, new AddLocalEventArgs() { name = name });

        }

        public void ClickCine(object sender, EventArgs e)
        {
            Label currentable = (Label)sender;
            string name = currentable.Name.Remove(0, 6);
            OnClickCine(this, new AddLocalEventArgs() { name = name });
        }

        public void ClickRestaurant(object sender, EventArgs e)
        {
            Label currentable = (Label)sender;
            string name = currentable.Name.Remove(0, 6);
            OnClickRestaurante(this, new AddLocalEventArgs() { name = name });
        }

        public void ClickRecreativa(object sender, EventArgs e)
        {
            Label currentable = (Label)sender;
            string name = currentable.Name.Remove(0, 6);
            OnClickRecreativa(this, new AddLocalEventArgs() { name = name });
        }

        public void Show_Info_Local(string name, string boss, int id, string hora_inicio, string hora_final, List<string> categorias,
            bool mesas,int ver_mesas, int salas)
        {
            panel_info_local.Visible = true;
            panel_ver_info_locales.Visible = true;
            int pos_x = 50;
            int pos_y = 20;
            panel_info_local.Controls.Add(Add_Label("Nombre Local: " + name, pos_x, pos_y));
            panel_info_local.Controls.Add(Add_Label("Jefe local: " + boss, pos_x, pos_y + 30));
            panel_info_local.Controls.Add(Add_Label("Id local: " + id, pos_x, pos_y + 60));
            panel_info_local.Controls.Add(Add_Label("Hora Inicio: " + hora_inicio, pos_x, pos_y + 90));
            panel_info_local.Controls.Add(Add_Label("Hora Final: " + hora_final, pos_x, pos_y + 120));
            if (ver_mesas == 1)
            {
                if (mesas)
                {
                    panel_info_local.Controls.Add(Add_Label("Este restaurante requiere reservacion", pos_x, pos_y + 150));
                }
                else
                {
                    panel_info_local.Controls.Add(Add_Label("Este restaurante no requiere reservacion", pos_x, pos_y + 150));
                }
            }
            if(categorias.Count() > 0)
            {
                string cat = "";
                foreach(string data in categorias)
                {
                    cat += data + ",";
                }
                cat.Remove(0, cat.Length - 1);
                panel_info_local.Controls.Add(Add_Label("Categorias: " + cat , pos_x, pos_y + 150));
            }
            if(salas != -1)
            {
                panel_info_local.Controls.Add(Add_Label("Salas Disponibles: " + salas, pos_x, pos_y + 150));
            }
        }
    }
}
