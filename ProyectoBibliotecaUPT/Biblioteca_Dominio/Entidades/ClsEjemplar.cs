using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsEjemplar
    {
        public int cod_ejemplar { get; set; }
        public int id_libro { get; set; }
        public string estado_ejemplar { get; set; }
        public string conserv_ejemplar { get; set; }
        public string ciclo { get; set; }
        public DateTime Fecha_Adquirido { get; set; }
        public DateTime Fecha_Registrado { get; set; }
        public ClsLibro libro { get; set; }

        public static ClsEjemplar RegistrarEjemplar(int asid_libro, string asestado, string asconservacion, string asciclo,
            DateTime asFecha_Adquirido, DateTime asFecha_Registrado)
        {
            return new ClsEjemplar()
            {
                id_libro = asid_libro,
                estado_ejemplar = asestado,
                conserv_ejemplar = asconservacion,
                ciclo = asciclo,
                Fecha_Adquirido = asFecha_Adquirido,
                Fecha_Registrado = asFecha_Registrado
            };
        }

        public void ModificarEjemplar(int asid_libro, string asestado, string asconservacion, string asciclo,
            DateTime asFecha_Adquirido, DateTime asFecha_Registrado)
        {
            id_libro = asid_libro;
            estado_ejemplar = asestado;
            conserv_ejemplar = asconservacion;
            ciclo = asciclo;
            Fecha_Adquirido = asFecha_Adquirido;
            Fecha_Registrado = asFecha_Registrado;
        }
    }
}
