using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsUsuario
    {
        public int id_usuario { get; set; }
        public int cod_persona { get; set; }
        public string nomb_usuario { get; set; }
        public string pass_usuario { get; set; }
        public int id_tipo { get; set; }
        public string estado_usuario { get; set; }
        public ClsPersona persona { get; set; }
        public ClsTipoUsuario tipo { get; set; }

        public static ClsUsuario RegistrarUsuario(int ascod_per, string asnomb_usu, string aspass_usu,
            int asid_tipo)
        {
            return new ClsUsuario()
            {
                cod_persona = ascod_per,
                nomb_usuario = asnomb_usu,
                pass_usuario = aspass_usu,
                id_tipo = asid_tipo,
                estado_usuario = "Activo"
            };
        }

        public void ModificarUsuario(int ascod_per, string asnomb_usu, string aspass_usu,
            int asid_tipo)
        {
            cod_persona = ascod_per;
            nomb_usuario = asnomb_usu;
            pass_usuario = aspass_usu;
            id_tipo = asid_tipo;
        }

        public void DescativarUsuario()
        {
            estado_usuario = "Desactivo";
        }

        public void AtivarUsuario()
        {
            estado_usuario = "Activo";
        }

    }
}
