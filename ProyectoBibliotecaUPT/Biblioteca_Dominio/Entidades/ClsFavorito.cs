using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsFavorito
    {
        public int cod_favoritos { get; set; }
        public int id_usuario { get; set; }
        public int cod_ejemplar { get; set; }
        public ClsUsuario usuario { get; set; }
        public ClsEjemplar ejemplar { get; set; }

        public static ClsFavorito AgregarFavorito(int asid_usu, int ascod_ejemplar)
        {
            return new ClsFavorito()
            {
                id_usuario = asid_usu,
                cod_ejemplar = ascod_ejemplar
            };
        }

        public void EliminarFavorito()
        {
            id_usuario = 0;
            cod_ejemplar = 0;
        }
    }
}
