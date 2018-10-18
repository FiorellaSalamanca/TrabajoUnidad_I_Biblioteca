using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class FavoritoMapeo : EntityTypeConfiguration<ClsFavorito>
    {
        public FavoritoMapeo()
        {
            ToTable("TBL_FAVORITO");
            HasKey(p => p.cod_favoritos);
            Property(p => p.cod_favoritos).HasColumnName("COD_FAVORITOS");
            Property(p => p.id_usuario).HasColumnName("ID_USUARIO");
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");

            HasRequired(m => m.usuario).WithMany().HasForeignKey(f => f.id_usuario);
            HasRequired(m => m.ejemplar).WithMany().HasForeignKey(f => f.cod_ejemplar);
        }
    }
}
