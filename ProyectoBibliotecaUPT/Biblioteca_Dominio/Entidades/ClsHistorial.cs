using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsHistorial
    {
        public int cod_historial { get; set; }
        public int cod_prestamo { get; set; }
        public int cod_reserva { get; set; }
        public int id_usuario { get; set; }
        public int cod_ejemplar { get; set; }
        public DateTime fecha { get; set; }
        public ClsPrestamo prestamo { get; set; }
        public ClsReserva reserva { get; set; }
        public ClsUsuario usuario { get; set; }
        public ClsEjemplar ejemplar { get; set; }

        public static ClsHistorial AgregarHistorial(int ascod_prestamo, int ascod_reserva, 
            int asid_usu, int ascod_ejemplar, DateTime asfecha)
        {
            return new ClsHistorial()
            {
                cod_prestamo = ascod_prestamo,
                cod_reserva = ascod_reserva,
                id_usuario = asid_usu,
                cod_ejemplar = ascod_ejemplar,
                fecha = asfecha
            };
        }

    }
}
