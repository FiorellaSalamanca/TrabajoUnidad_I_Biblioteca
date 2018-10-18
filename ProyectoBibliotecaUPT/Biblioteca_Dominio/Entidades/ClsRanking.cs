using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsRanking
    {
        public int cod_ranking { get; set; }
        public int cod_ejemplar { get; set; }
        public int num_prestamo { get; set; }
        public int num_puesto { get; set; }
        public ClsEjemplar ejemplar { get; set; }

        public static ClsRanking AgregarRanking(int ascod_ejemplar, int asnum_prestamo, int asnum_puesto)
        {
            return new ClsRanking()
            {
                cod_ejemplar = ascod_ejemplar,
                num_prestamo = asnum_prestamo,
                num_puesto = asnum_puesto
            };
        }

    }
}
