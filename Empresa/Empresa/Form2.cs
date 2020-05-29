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
    public partial class Form2 : Form
    {
        List<string> titulos = new List<string>();
        List<Label> locales = new List<Label>();
        public Form2(List<string> titulos)
        {
            InitializeComponent();
            this.titulos = titulos;
            OnShowInfo(titulos);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void OnShowInfo(List<string> titulos)
        {
            for (int i = 0; i < locales.Count(); i++)
            {
                panel_info.Controls.Remove(locales[i]);
            }
            locales.Clear();
            int pos_x = 25;
            int pos_y = 15;
            foreach(string data in titulos)
            {
                Label local = Add_Label(data, pos_x, pos_y);
                panel_info.Controls.Add(local);
                locales.Add(local);
                pos_y += 30;
            }
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
    }
}
