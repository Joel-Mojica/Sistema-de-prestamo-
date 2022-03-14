using capaDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class N_Prestamos
    {
        E_Prestamos objEntida = new E_Prestamos();
        D_Prestamos objDatos= new D_Prestamos();



        public List<E_Prestamos> buscarClienteP(string buscar)
        {
            return objDatos.buscarCliente(buscar);
        }

        public void agregarClienteP(E_Prestamos Prestamos)
        {
            objDatos.agregarCliente(Prestamos);
        }

        public void editarClienteP(E_Prestamos Prestamos)
        {
            objDatos.editarCliente(Prestamos);
        }

        public void eliminarClienteP(E_Prestamos Prestamos)
        {
            objDatos.eliminarCliente(Prestamos);
        }






















        //Viejos metodos




      /*  
        public void guardarCliente(string nombre, string apellido, int edad, int numeroId, string direccion, int pagoPrestamo, int interesPrestamo, int montoPrestamo, int tiempoPrestamo, int cuotaPrestamo)
        {
            objDatos.guardar(nombre,apellido,edad,numeroId,direccion,pagoPrestamo,interesPrestamo,montoPrestamo,tiempoPrestamo,cuotaPrestamo);
        }

        public void actualizarCliente(int id, string nombre, string apellido, int edad, string direccion)
        {
            objDatos.actualizar(id,nombre, apellido, edad, direccion);
        }

        public void borrarCliente(int id)
        {
            objDatos.borrar(id);
        }

        public void traerDatosPrestamo(int id, int montoPrestamo, string nombre, string apellido)
        {
            //objDatos.traer(id,montoPrestamo,nombre,apellido);
           
        }

        public void pagarCuotaPrestamo(int id, int montoPrestamo, int pagoPrestamo, int cuotaPrestamo)
        {
           // objDatos.pagarCuota(id, montoPrestamo, pagoPrestamo, cuotaPrestamo);
        }

        /*
        public DataTable listarTabla()
        {
            return objDatos.listarTabla();
        }
        */
       
    }
}
