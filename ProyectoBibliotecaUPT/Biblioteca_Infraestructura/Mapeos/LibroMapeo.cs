using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class LibroMapeo : EntityTypeConfiguration<ClsLibro>
    {
        public LibroMapeo()
        {
            ToTable("TBL_LIBRO");
            HasKey(p => p.id_libro);
            Property(p => p.id_libro).HasColumnName("ID_LIBRO");
            Property(p => p.id_autor).HasColumnName("ID_AUTOR");
            Property(p => p.id_editorial).HasColumnName("ID_EDITORIAL");
            Property(p => p.id_edicion).HasColumnName("ID_EDICION");
            Property(p => p.id_categoria).HasColumnName("ID_CATEGORIA");
            Property(p => p.tit_libro).HasColumnName("TIT_LIBRO").HasMaxLength(350);
            Property(p => p.subtit_libro).HasColumnName("SUBTIT_LIBRO").HasMaxLength(250);
            Property(p => p.estado_libro).HasColumnName("ESTADO_LIBRO").HasMaxLength(15);
            Property(p => p.idioma_libro).HasColumnName("IDIOMA_LIBRO").HasMaxLength(50);
            Property(p => p.num_pag_libro).HasColumnName("NUM_PAG_LIBRO");
            Property(p => p.num_ejemplares).HasColumnName("NUM_EJEMPLARES");

            HasRequired(m => m.autor).WithMany().HasForeignKey(f => f.id_autor);
            HasRequired(m => m.editorial).WithMany().HasForeignKey(f => f.id_editorial);
            HasRequired(m => m.edicion).WithMany().HasForeignKey(f => f.id_edicion);
            HasRequired(m => m.categoria).WithMany().HasForeignKey(f => f.id_categoria);
        }
    }
}
