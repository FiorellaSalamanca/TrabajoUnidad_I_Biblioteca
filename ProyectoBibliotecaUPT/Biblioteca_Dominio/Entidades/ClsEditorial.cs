using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsEditorial
    {
        public int id_editorial { get; set; }
        public string nomb_editorial { get; set; }
        public string dir_editorial { get; set; }
        public string tel_editorial { get; set; }

        public static ClsEditorial RegistrarEditorial(string asnomb_editorial, string asdir_editorial,
            string astel_editorial)
        {
            return new ClsEditorial()
            {
                nomb_editorial = asnomb_editorial,
                dir_editorial = asdir_editorial,
                tel_editorial = astel_editorial
            };
        }

        public void ModificarEditorial(string asnomb_editorial, string asdir_editorial,
            string astel_editorial)
        {
            nomb_editorial = asnomb_editorial;
            dir_editorial = asdir_editorial;
            tel_editorial = astel_editorial;
        }
    }
}
