using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsTipoUsuario
    {
        public int id_tipo { get; set; }
        public string desc_tipo { get; set; }

        public static ClsTipoUsuario RegistrarTipoUsuario(string asdesc_tipo)
        {
            return new ClsTipoUsuario()
            {
                desc_tipo = asdesc_tipo
            };
        }

        public void ModificarTipoUsuario (string asdesc_tipo)
        {
            desc_tipo = asdesc_tipo;
        }
    }
}
