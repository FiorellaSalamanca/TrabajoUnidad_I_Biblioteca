using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsReserva
    {
        public int cod_reserva { get; set; }
        public int id_usuario { get; set; }
        public int cod_ejemplar { get; set; }
        public DateTime fecha_reserva { get; set; }
        public int periodo { get; set; }
        public ClsUsuario usuario { get; set; }
        public ClsEjemplar ejemplar { get; set; }

        public static ClsReserva AgregarReserva(int asid_usu, int ascod_ejemplar, 
            DateTime asfecha_reserva, int asperiodo)
        {
            return new ClsReserva()
            {
                id_usuario = asid_usu,
                cod_ejemplar = ascod_ejemplar,
                fecha_reserva = asfecha_reserva,
                periodo = asperiodo
            };
        }

        public void CancelarReserva()
        {
            id_usuario = 0;
            cod_ejemplar = 0;
            fecha_reserva = Convert.ToDateTime(0);
            periodo = 0;
        }
    }
}
