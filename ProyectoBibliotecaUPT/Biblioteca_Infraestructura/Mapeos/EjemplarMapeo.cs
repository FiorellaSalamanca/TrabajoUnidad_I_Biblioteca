using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca_Infraestructura.Mapeos
{
    public class EjemplarMapeo : EntityTypeConfiguration<ClsEjemplar>
    {
        public EjemplarMapeo()
        {
            ToTable("TBL_EJEMPLAR");
            HasKey(p => p.cod_ejemplar);
            Property(p => p.cod_ejemplar).HasColumnName("COD_EJEMPLAR");
            Property(p => p.id_libro).HasColumnName("ID_LIBRO");
            Property(p => p.estado_ejemplar).HasColumnName("ESTADO_EJEMPLAR").HasMaxLength(100);
            Property(p => p.conserv_ejemplar).HasColumnName("CONSERV_EJEMPLAR").HasMaxLength(100);
            Property(p => p.ciclo).HasColumnName("CICLO").HasMaxLength(20);
            Property(p => p.Fecha_Adquirido).HasColumnName("FECHA_ADQUIRIDO");
            Property(p => p.Fecha_Registrado).HasColumnName("FECHA_REGISTRADO");

            HasRequired(m => m.libro).WithMany().HasForeignKey(f => f.id_libro);
        }
    }
}
