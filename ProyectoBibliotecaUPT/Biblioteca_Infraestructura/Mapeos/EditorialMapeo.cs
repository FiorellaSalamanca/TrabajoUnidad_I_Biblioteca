using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class EditorialMapeo : EntityTypeConfiguration<ClsEditorial>
    {
        public EditorialMapeo()
        {
            ToTable("TBL_EDITORIAL");
            HasKey(p => p.id_editorial);
            Property(p => p.id_editorial).HasColumnName("ID_EDITORIAL");
            Property(p => p.nomb_editorial).HasColumnName("NOMB_EDITORIAL").HasMaxLength(250);
            Property(p => p.dir_editorial).HasColumnName("DIR_EDITORIAL").HasMaxLength(550);
            Property(p => p.tel_editorial).HasColumnName("TEL_EDITORIAL").HasMaxLength(15);
        }
    }
}
