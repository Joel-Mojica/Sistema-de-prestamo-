using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_Prestamos
    {

        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private int numeroId;
        private string direccion;


        private int pagoPrestamo;
        private int interesPrestamo;
        private int montoPrestamo;
        private int tiempoPrestamo;
        private int cuotaPrestamo;
        
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public int NumeroId { get => numeroId; set => numeroId = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int PagoPrestamo { get => pagoPrestamo; set => pagoPrestamo = value; }
        public int InteresPrestamo { get => interesPrestamo; set => interesPrestamo = value; }
        public int MontoPrestamo { get => montoPrestamo; set => montoPrestamo = value; }
        public int TiempoPrestamo { get => tiempoPrestamo; set => tiempoPrestamo = value; }
        public int CuotaPrestamo { get => cuotaPrestamo; set => cuotaPrestamo = value; }




















        /*
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int numeroId { get; set; }
        public string direccion { get; set; }


        public int pagoPrestamo { get; set; }
        public int interesPrestamo { get; set; }
        public int montoPrestamo { get; set; }
        public int tiempoPrestamo { get; set; }
        public int cuotaPrestamo { get; set; }
        */


    }
}
