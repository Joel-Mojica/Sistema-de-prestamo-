using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocios;
using Entidad;
using capaDatos;

namespace capaPresentacion
{
    public partial class baseDeDatos : Form
    {
        N_Prestamos objNego = new N_Prestamos();
        E_Prestamos objEnti = new E_Prestamos();
        public baseDeDatos()
        {
            InitializeComponent();
        }

        private void baseDeDatos_Load(object sender, EventArgs e)
        {
            mostrarDatos("");
        }

        public void mostrarDatos(string buscar)
        {
            dataGridViewBuscar.DataSource = objNego.buscarClienteP(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtBuscar.Text);
        }
    }
}
