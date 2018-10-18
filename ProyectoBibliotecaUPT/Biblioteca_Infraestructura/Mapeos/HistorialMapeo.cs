using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    class HistorialMapeo : EntityTypeConfiguration<ClsHistorial>
    {
        public HistorialMapeo()
        {
            ToTable("TBL_HISTORIAL");
            HasKey(p => p.cod_historial);
            Property(p => p.cod_historial).HasColumnName("COD_HISTORIAL");
            Property(p => p.cod_prestamo).HasColumnName("COD_PRESTAMO");
            Property(p => p.cod_reserva).HasColumnName("COD_RESERVA");
            Property(p => p.id_usuario).HasColumnName("ID_USUARIO");
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");
            Property(p => p.fecha).HasColumnName("FECHA");

            HasRequired(m => m.prestamo).WithMany().HasForeignKey(f => f.cod_prestamo);
            HasRequired(m => m.reserva).WithMany().HasForeignKey(f => f.cod_reserva);
            HasRequired(m => m.usuario).WithMany().HasForeignKey(f => f.id_usuario);
            HasRequired(m => m.ejemplar).WithMany().HasForeignKey(f => f.cod_ejemplar);
        }
    }
}
