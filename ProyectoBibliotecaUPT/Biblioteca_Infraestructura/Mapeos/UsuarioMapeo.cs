using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<ClsUsuario>
    {
        public UsuarioMapeo()
        {
            ToTable("TBL_USUARIO");
            HasKey(p => p.id_usuario);
            Property(p => p.id_usuario).HasColumnName("ID_USUARIO");
            Property(p => p.cod_persona).HasColumnName("COD_PERSONA");
            Property(p => p.nomb_usuario).HasColumnName("NOMB_USUARIO").HasMaxLength(50);
            Property(p => p.pass_usuario).HasColumnName("PASS_USUARIO").HasMaxLength(100);
            Property(p => p.id_tipo).HasColumnName("ID_TIPO");
            Property(p => p.estado_usuario).HasColumnName("ESTADO_USUARIO").HasMaxLength(10);

            HasRequired(m => m.persona).WithMany().HasForeignKey(f => f.cod_persona);
            HasRequired(m => m.tipo).WithMany().HasForeignKey(f => f.id_tipo);
        }
    }
}
