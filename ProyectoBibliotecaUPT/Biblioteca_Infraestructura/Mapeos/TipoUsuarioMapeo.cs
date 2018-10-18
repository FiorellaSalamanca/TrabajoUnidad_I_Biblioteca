using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class TipoUsuarioMapeo : EntityTypeConfiguration<ClsTipoUsuario>
    {
        public TipoUsuarioMapeo()
        {
            ToTable("TBL_TIPO_USUARIO");
            HasKey(p => p.id_tipo);
            Property(p => p.id_tipo).HasColumnName("ID_TIPO");
            Property(p => p.desc_tipo).HasColumnName("DESC_TIPO").HasMaxLength(20);
        }
    }
}
