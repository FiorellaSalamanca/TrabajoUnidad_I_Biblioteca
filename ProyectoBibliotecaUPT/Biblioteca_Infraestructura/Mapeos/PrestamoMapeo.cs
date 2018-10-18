using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    class PrestamoMapeo : EntityTypeConfiguration<ClsPrestamo>
    {
        public PrestamoMapeo()
        {
            ToTable("TBL_PRESTAMO");
            HasKey(p => p.cod_prestamo);
            Property(p => p.cod_prestamo).HasColumnName("COD_PRESTAMO");
            Property(p => p.cod_reserva).HasColumnName("COD_RESERVA");
            Property(p => p.fecha_prestamo).HasColumnName("FECHA_PRESTAMO");
            Property(p => p.fecha_entrega).HasColumnName("FECHA_ENTREGA");

            HasRequired(m => m.reserva).WithMany().HasForeignKey(f => f.cod_reserva);
        }
    }
}
