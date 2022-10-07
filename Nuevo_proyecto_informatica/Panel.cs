using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuevo_proyecto_informatica
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directorium directorium = new Directorium();
            directorium.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendario calendario = new Calendario();
            calendario.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proyectos_Actuales proyectos_actuales = new Proyectos_Actuales();
            proyectos_actuales.Show();
        }
    }
}
