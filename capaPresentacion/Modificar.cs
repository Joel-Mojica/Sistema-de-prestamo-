using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using capaNegocios;

namespace capaPresentacion
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        N_Prestamos objNego = new N_Prestamos();
        E_Prestamos objEnti = new E_Prestamos();

        private void Modificar_Load(object sender, EventArgs e)
        {
            //  DataTable dt = objNego.listarTabla();
            // dataGridView1.DataSource = dt;

            mostrarDatos("");
        }

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = objNego.buscarClienteP(buscar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // objNego.listarTabla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
            objEnti.Nombre = txtNombre.Text;
            objEnti.Apellido = txtApellido.Text;
            objEnti.Edad = int.Parse(txtEdad.Text);
            objEnti.Direccion = txtDireccion.Text;

            objNego.editarClienteP(objEnti);

                MessageBox.Show("Datos actualizados");
                
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";

                mostrarDatos("");

               

            }
            catch(Exception Error)
            {
                MessageBox.Show("No se pudo actualizar cliente" + Error);
            }









            /*
             * Metodos usados antes de la actualizacion y uso de store procedure
            try
            {
                objEnti.Id = int.Parse(txtId.Text);
                objEnti.Nombre = txtNombre.Text;
                objEnti.Apellido = txtApellido.Text;
                objEnti.Edad = int.Parse(txtEdad.Text);
                objEnti.Direccion = txtDireccion.Text;


                objNego.actualizarCliente(objEnti.Id, objEnti.Nombre, objEnti.Apellido, objEnti.Edad, objEnti.Direccion);

                MessageBox.Show("tus datos se actualizaron exitosamente");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            DataTable dt = objNego.listarTabla();
            dataGridView1.DataSource = dt;
        
          */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEnti.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); 
                txtEdad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
                txtDireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
        }
    }   
}
