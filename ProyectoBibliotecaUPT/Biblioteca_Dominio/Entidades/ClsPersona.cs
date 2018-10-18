using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsPersona
    {
        public int cod_persona { get; set; }
        public string dni_persona { get; set; }
        public string nomb_persona { get; set; }
        public string apel_persona { get; set; }
        public string sexo_persona { get; set; }
        public string email_persona { get; set; }
        public string tel_persona { get; set; }
        public string foto_persona { get; set; }
        public string estado_persona { get; set; }

        public static ClsPersona RegistrarPersona(string asdni_per, string asnomb_per, string asapel_per,
            string assexo_per, string asemail_per, string astel_per, string asfoto_per)
        {
            return new ClsPersona()
            {
                dni_persona = asdni_per,
                nomb_persona = asnomb_per,
                apel_persona = asapel_per,
                sexo_persona = assexo_per,
                email_persona = asemail_per,
                tel_persona = astel_per,
                foto_persona = asfoto_per,
                estado_persona = "Activo"
            };
        }

        public void ModificarPersona(string asdni_per, string asnomb_per, string asapel_per,
            string assexo_per, string asemail_per, string astel_per, string asfoto_per)
        {
            dni_persona = asdni_per;
            nomb_persona = asnomb_per;
            apel_persona = asapel_per;
            sexo_persona = assexo_per;
            email_persona = asemail_per;
            tel_persona = astel_per;
            foto_persona = asfoto_per;
        }

        public void DescativarPersona()
        {
            estado_persona = "Desactivo";
        }

        public void AtivarPersona()
        {
            estado_persona = "Activo";
        }

    }
}
