using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class ReservaMapeo : EntityTypeConfiguration<ClsReserva>
    {
        public ReservaMapeo()
        {
            ToTable("TBL_RESERVA");
            HasKey(p => p.cod_reserva);
            Property(p => p.cod_reserva).HasColumnName("COD_RESERVA");
            Property(p => p.id_usuario).HasColumnName("ID_USUARIO");
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");
            Property(p => p.fecha_reserva).HasColumnName("FECHA_RESERVA");
            Property(p => p.periodo).HasColumnName("PERIODO");

            HasRequired(m => m.usuario).WithMany().HasForeignKey(f => f.id_usuario);
            HasRequired(m => m.ejemplar).WithMany().HasForeignKey(f => f.cod_ejemplar);
        }
    }
}
