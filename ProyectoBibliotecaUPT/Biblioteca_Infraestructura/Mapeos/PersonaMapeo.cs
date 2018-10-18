using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Biblioteca_Infraestructura.Mapeos
{
    public class PersonaMapeo : EntityTypeConfiguration<ClsPersona>
    {
        public PersonaMapeo()
        {
            ToTable("TBL_PERSONA");
            HasKey(p => p.cod_persona);
            Property(p => p.cod_persona).HasColumnName("COD_PERSONA");
            Property(p => p.dni_persona).HasColumnName("DNI_PERSONA").HasMaxLength(8);
            Property(p => p.nomb_persona).HasColumnName("NOMB_PERSONA").HasMaxLength(250);
            Property(p => p.apel_persona).HasColumnName("APEL_PERSONA").HasMaxLength(250);
            Property(p => p.sexo_persona).HasColumnName("SEXO_PERSONA").HasMaxLength(1);
            Property(p => p.email_persona).HasColumnName("EMAIL_PERSONA").HasMaxLength(250);
            Property(p => p.tel_persona).HasColumnName("TEL_PERSONA").HasMaxLength(15);
            Property(p => p.foto_persona).HasColumnName("FOTO_PERSONA").HasMaxLength(250);
            Property(p => p.estado_persona).HasColumnName("ESTADO_PERSONA").HasMaxLength(10);
        }
    }
}
