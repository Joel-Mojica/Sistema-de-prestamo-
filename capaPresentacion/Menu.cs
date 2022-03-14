using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form modificar = new Modificar();
            modificar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form borrar = new borrar();
            borrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form pagos = new pagos();
            pagos.Show();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            Form baseDatos = new baseDeDatos();
            baseDatos.Show();
        }
    }
}
