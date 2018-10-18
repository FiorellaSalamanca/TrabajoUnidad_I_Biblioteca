using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Biblioteca_Infraestructura.Mapeos
{
    public class AutorMapeo : EntityTypeConfiguration<ClsAutor>
    {
        public AutorMapeo()
        {
            ToTable("TBL_AUTOR");
            HasKey(p => p.id_autor);
            Property(p => p.id_autor).HasColumnName("ID_AUTOR");
            Property(p => p.nom_autor).HasColumnName("NOM_AUTOR").HasMaxLength(250);
            Property(p => p.apel_autor).HasColumnName("APEL_AUTOR").HasMaxLength(250);
        }
    }
}