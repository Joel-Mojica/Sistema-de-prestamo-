using capaNegocios;
using Entidad;
using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        N_Prestamos objNego = new N_Prestamos();
        E_Prestamos objEnti = new E_Prestamos();

        private void form2_Load(object sender, EventArgs e)
        {
            mostrarDatos(""); 

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {

                objEnti.Nombre = txtNombre.Text;
                objEnti.Apellido = txtApellido.Text;
                objEnti.Edad = Convert.ToInt32(txtEdad.Text);
                objEnti.NumeroId = Convert.ToInt32(txtNumeroId.Text);
                objEnti.Direccion = txtDireccion.Text;

                // txtPagoPrestamo.Text;
                objEnti.InteresPrestamo = Convert.ToInt32(txtInteresPrestamo.Text);
                objEnti.MontoPrestamo = Convert.ToInt32(txtMontoPrestamo.Text);
                objEnti.TiempoPrestamo = Convert.ToInt32(txtTiempoPrestamo.Text);
                // txtCuotaPrestamo.Text;

                objNego.agregarClienteP(objEnti);

                MessageBox.Show("Se ha agregado al cliente");
                mostrarDatos("");

                limpiar();

            }
            catch (Exception Error)
            {
                MessageBox.Show("No se pudo guardar" + Error);
            }
        





        /*
            try
            {
            objEnti.Nombre = txtNombre.Text;
            objEnti.Apellido = txtApellido.Text;
            objEnti.Edad = int.Parse(txtEdad.Text);
            objEnti.NumeroId = int.Parse(txtNumeroId.Text);
            objEnti.Direccion = txtDireccion.Text;
            objEnti.PagoPrestamo = int.Parse(txtPagoPrestamo.Text);//cuotas menzuales
            objEnti.InteresPrestamo = 0;

            objEnti.MontoPrestamo = int.Parse(txtMontoPrestamo.Text);
                if (objEnti.MontoPrestamo <= 200000)
                {
                    objEnti.InteresPrestamo = 22;
                }
                else if (objEnti.MontoPrestamo <= 400000)
                {
                    objEnti.InteresPrestamo = 16;
                }
                else
                {
                    objEnti.InteresPrestamo = 14;
                }
                

            objEnti.TiempoPrestamo = int.Parse(txtTiempoPrestamo.Text);



            objEnti.CuotaPrestamo = 0;
        
            objNego.guardarCliente(objEnti.Nombre, objEnti.Apellido, objEnti.Edad, objEnti.NumeroId, objEnti.Direccion, objEnti.PagoPrestamo, objEnti.InteresPrestamo, objEnti.MontoPrestamo, objEnti.TiempoPrestamo, objEnti.CuotaPrestamo);
             
            MessageBox.Show("tus datos se guardaron exitosamente");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            */
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
                //ya no lo uso 
              //  objNego.listarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            
            //Este metodo ya no es utilizado este boton me mostraba el datagrid con los datos
            //DataTable dt = objNego.listarTabla();
           // dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void mostrarDatos(string buscar)
        {
            dataGridView1.DataSource = objNego.buscarClienteP(buscar);
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtNumeroId.Text = "";
            txtDireccion.Text = "";

            txtPagoPrestamo.Text = "";
            txtInteresPrestamo.Text = "";
            txtMontoPrestamo.Text = "";
            txtTiempoPrestamo.Text = "";
        }
    }
}
