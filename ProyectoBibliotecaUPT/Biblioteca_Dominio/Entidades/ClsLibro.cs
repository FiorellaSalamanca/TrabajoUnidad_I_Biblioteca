using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Dominio.Entidades
{
    public class ClsLibro
    {
        public int id_libro { get; set; }
        public int id_autor { get; set; }
        public int id_editorial { get; set; }
        public int id_edicion { get; set; }
        public int id_categoria { get; set; }
        public string tit_libro { get; set; }
        public string subtit_libro { get; set; }
        public string estado_libro { get; set; }
        public string idioma_libro { get; set; }
        public int num_pag_libro { get; set; }
        public int num_ejemplares { get; set; }
        public ClsAutor autor { get; set; }
        public ClsEdicion edicion { get; set; }
        public ClsEditorial editorial { get; set; }
        public ClsCategoria categoria { get; set; }

        public static ClsLibro RegistrarLibro(int asid_autor, int asid_editorial, int asid_edicion, 
            int asid_categoria, string astitulo, string assubtitulo, string asidioma, 
            int asnum_paginas, int asnum_ejemplares)
        {
            return new ClsLibro()
            {
                id_autor = asid_autor,
                id_editorial = asid_editorial,
                id_edicion = asid_edicion,
                id_categoria = asid_categoria,
                tit_libro = astitulo,
                subtit_libro = assubtitulo,
                estado_libro = "Activo",
                idioma_libro = asidioma,
                num_pag_libro = asnum_paginas,
                num_ejemplares = asnum_ejemplares
            };
        }

        public void ModificarLibro(int asid_autor, int asid_editorial, int asid_edicion,
            int asid_categoria, string astitulo, string assubtitulo, string asidioma,
            int asnum_paginas, int asnum_ejemplares)
        {
            id_autor = asid_autor;
            id_editorial = asid_editorial;
            id_edicion = asid_edicion;
            id_categoria = asid_categoria;
            tit_libro = astitulo;
            subtit_libro = assubtitulo;
            idioma_libro = asidioma;
            num_pag_libro = asnum_paginas;
            num_ejemplares = asnum_ejemplares;
        }

        public void DescativarLibro()
        {
            estado_libro = "Desactivo";
        }

        public void AtivarLibro()
        {
            estado_libro = "Activo";
        }
    }
}
