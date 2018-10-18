using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsCategoria
    {
        public int id_categoria { get; set; }
        public string nomb_categoria { get; set; }

        public static ClsCategoria RegistrarCategoria(string asnomb_categoria)
        {
            return new ClsCategoria()
            {
                nomb_categoria = asnomb_categoria
            };
        }

        public void ModificarCategoria(string asNuevonomb_categoria)
        {
            nomb_categoria = asNuevonomb_categoria;
        }
    }
}
