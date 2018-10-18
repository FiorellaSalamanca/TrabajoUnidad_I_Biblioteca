using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsAutor
    {
        public int id_autor { get; set; }
        public string nom_autor { get; set; }
        public string apel_autor { get; set; }
 
        public static ClsAutor RegistrarAutor(string nomb, string apel)
        {
            return new ClsAutor()
            {
                nom_autor = nomb,
                apel_autor = apel
            };
        }
        
        public void ModificarAutor(string nomb, string apel)
        {
            nom_autor = nomb;
            apel_autor = apel;
        }
    }
}
