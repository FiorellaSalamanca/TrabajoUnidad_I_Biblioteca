using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    class RankingMapeo : EntityTypeConfiguration<ClsRanking>
    {
        public RankingMapeo()
        {
            ToTable("TBL_RANKING");
            HasKey(p => p.cod_ranking);
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");
            Property(p => p.num_prestamo).HasColumnName("NUM_PRESTAMO");
            Property(p => p.num_puesto).HasColumnName("NUM_PUESTO");

            HasRequired(m => m.ejemplar).WithMany().HasForeignKey(f => f.cod_ejemplar);
        }
    }
}
