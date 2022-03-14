using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidad;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class D_Prestamos
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);

        SqlCommand comando;


        public List<E_Prestamos> buscarCliente(string buscar)
        {
            
            SqlDataReader leerFilas;
            comando = new SqlCommand("SP_buscarPrestamo", con);
            comando.CommandType = CommandType.StoredProcedure;
            con.Open();

            comando.Parameters.AddWithValue("@buscar", buscar);
            leerFilas = comando.ExecuteReader();

            List<E_Prestamos> listar = new List<E_Prestamos>();
            while (leerFilas.Read())
            {
                listar.Add(new E_Prestamos
                {
                    Id = leerFilas.GetInt32(0),
                    Nombre = leerFilas.GetString(1),
                    Apellido = leerFilas.GetString(2),
                    Edad = leerFilas.GetInt32(3),
                    NumeroId = leerFilas.GetInt32(4),
                    Direccion = leerFilas.GetString(5),

                    PagoPrestamo = leerFilas.GetInt32(6),
                    InteresPrestamo = leerFilas.GetInt32(7),
                    MontoPrestamo = leerFilas.GetInt32(8),
                    TiempoPrestamo = leerFilas.GetInt32(9),

                });
            }
            con.Close();
            leerFilas.Close();
            return listar;

        }


        public void agregarCliente(E_Prestamos Prestamos)
        {
            comando = new SqlCommand("SP_agregarCliente", con);
            comando.CommandType = CommandType.StoredProcedure;
            con.Open();
            
            comando.Parameters.AddWithValue("@nombre", Prestamos.Nombre);
            comando.Parameters.AddWithValue("@apellido", Prestamos.Apellido);
            comando.Parameters.AddWithValue("@edad", Prestamos.Edad);
            comando.Parameters.AddWithValue("@numeroId", Prestamos.NumeroId);
            comando.Parameters.AddWithValue("@direccion", Prestamos.Direccion);
            comando.Parameters.AddWithValue("@pagoPrestamo", Prestamos.PagoPrestamo);
            comando.Parameters.AddWithValue("@interesPrestamo", Prestamos.InteresPrestamo);
            comando.Parameters.AddWithValue("@montoPrestamo", Prestamos.MontoPrestamo);
            comando.Parameters.AddWithValue("@tiempoPrestamo", Prestamos.TiempoPrestamo);
            comando.Parameters.AddWithValue("@cuotaPrestamo", Prestamos.CuotaPrestamo);

            comando.ExecuteNonQuery();
            con.Close();
        }


        public void editarCliente(E_Prestamos Prestamos)
        {
            comando = new SqlCommand("SP_editarCliente", con);
            comando.CommandType = CommandType.StoredProcedure;
            con.Open();

            comando.Parameters.AddWithValue("@id", Prestamos.Id);
            comando.Parameters.AddWithValue("@nombre", Prestamos.Nombre);
            comando.Parameters.AddWithValue("@apellido", Prestamos.Apellido);
            comando.Parameters.AddWithValue("@edad", Prestamos.Edad);
            comando.Parameters.AddWithValue("@numeroId", Prestamos.NumeroId);
            comando.Parameters.AddWithValue("@direccion", Prestamos.Direccion);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public void eliminarCliente(E_Prestamos Prestamos)
        {
            comando = new SqlCommand("SP_eliminarCliente", con);
            comando.CommandType = CommandType.StoredProcedure;
            con.Open();

            comando.Parameters.AddWithValue("@id", Prestamos.Id);
            comando.ExecuteNonQuery();
            con.Close();
        }


















        //Datos viejos



        /*
        //Retorna toda la tabla de base de datos prestamos
        public DataTable listarTabla()
        {
            comando = new SqlCommand("listarNombres", con);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptar.Fill(dt);
            return dt;

        }
        


        //Metodo para guardar(agregar) todos los datos ingresados(del cliente) por primera vez
        public void guardar(string nombre, string apellido, int edad, int numeroId, string direccion, int pagoPrestamo, int interesPrestamo, int montoPrestamo, int tiempoPrestamo, int cuotaPrestamo)
        {
            con.Open();
            string lineaComandoSql = $"insert into Prestamos values('{nombre}','{apellido}',{edad},{numeroId},'{direccion}',{pagoPrestamo},{interesPrestamo},{montoPrestamo},{tiempoPrestamo},{cuotaPrestamo})";
            comando = new SqlCommand(lineaComandoSql, con);
            comando.ExecuteNonQuery();
            con.Close();
        }


        public void actualizar(int id, string nombre, string apellido, int edad, string direccion)
        {
            con.Open();
            string lineaComandoSql = $"update Prestamos set nombre = '{nombre}', apellido = '{apellido}', edad = {edad}, direccion = '{direccion}' where id = {id}";
            comando = new SqlCommand(lineaComandoSql, con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void pagarCuota(int id, int montoPrestamo, int pagoPrestamo, int cuotaPrestamo)
        {
            
              //con.Open();
             // string lineaComandoSql = $"update Prestamos set montoPrestamo = {montoPrestamo}, pagoPrestamo = {pagoPrestamo}, cuotaPrestamo = {cuotaPrestamo} where id = {id}";
             // comando = new SqlCommand(lineaComandoSql, con);
             /// comando.ExecuteNonQuery();
             // con.Close();
            // aqui lleva un sierre de comentario para que funcione el codigo
            
        }

        public void borrar(int id)
        {
            con.Open();
            string lineaComandoSql = $"delete from Prestamos where id = {id}";
            comando = new SqlCommand(lineaComandoSql, con);
            comando.ExecuteNonQuery();
            con.Close();
        }


        //Metodo aun no funciona
        public void traer(int id, int montoPrestamo, string nombre, string apellido)
        {
            //E_Prestamos objEnti = new E_Prestamos();
            // objEnti.montoPrestamo =  objEnti.montoPrestamo - objEnti.pagoPrestamo;

            con.Open();
            string lineaComandoSql = $"select montoPrestamo,nombre,apellido from Prestamos where id = {id}";
            comando = new SqlCommand(lineaComandoSql, con);
            SqlDataReader traerRegistro = comando.ExecuteReader();
            if (traerRegistro.Read())
            {
                montoPrestamo = (int)traerRegistro["montoPrestamo"];
                nombre = traerRegistro["nombre"].ToString();
                apellido = traerRegistro["apellido"].ToString();
            }
            else
            {
                System.Console.WriteLine("No existe el registro introducido");
            }
            con.Close();

        }

        */

    }
}








 