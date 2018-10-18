using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class EdicionMapeo : EntityTypeConfiguration<ClsEdicion>
    {
        public EdicionMapeo()
        {
            ToTable("TBL_EDICION");
            HasKey(p => p.id_edicion);
            Property(p => p.id_edicion).HasColumnName("ID_EDICION");
            Property(p => p.num_edicion).HasColumnName("NUM_EDICION").HasMaxLength(250);
            Property(p => p.num_ISBN).HasColumnName("NUM_ISBN").HasMaxLength(350);
            Property(p => p.anio_publicacion).HasColumnName("AÑO_PUBLICACION").HasMaxLength(5);
        }
    }
}
