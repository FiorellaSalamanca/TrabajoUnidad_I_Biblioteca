using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{ 
    public class ClsEdicion
    {
        public int id_edicion { get; set; }
        public string num_edicion { get; set; }
        public string num_ISBN { get; set; }
        public string anio_publicacion { get; set; }

        public static ClsEdicion RegistrarEdicion(string asnum_edicion, string asnum_ISBN, 
            string asanio_publicacion)
        {
            return new ClsEdicion()
            {
                num_edicion = asnum_edicion,
                num_ISBN = asnum_ISBN,
                anio_publicacion = asanio_publicacion
            };
        }

        public void ModificarEdicion(string asnum_edicion, string asnum_ISBN,
            string asanio_publicacion)
        {
            num_edicion = asnum_edicion;
            num_ISBN = asnum_ISBN;
            anio_publicacion = asanio_publicacion;
        }
    }
}
