using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsPrestamo
    {
        public int cod_prestamo { get; set; }
        public int cod_reserva { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime fecha_entrega { get; set; }
        public ClsReserva reserva { get; set; }

        public static ClsPrestamo AgregarPrestamo(int ascod_reserva, DateTime asfecha_prestamo,
            DateTime asfecha_entrega)
        {
            return new ClsPrestamo()
            {
                cod_reserva = ascod_reserva,
                fecha_prestamo = asfecha_prestamo,
                fecha_entrega = asfecha_entrega
            };
        }

        public void ModificaPrestamo(DateTime asfecha_prestamo, DateTime asfecha_entrega)
        {
            fecha_prestamo = asfecha_prestamo;
            fecha_entrega = asfecha_entrega;
        }
    }
}
