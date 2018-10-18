using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Biblioteca_Infraestructura.Mapeos
{
    public class CategoriaMapeo : EntityTypeConfiguration<ClsCategoria>
    {
        public CategoriaMapeo()
        {
            ToTable("TBL_CATEGORIA");
            HasKey(p => p.id_categoria);
            Property(p => p.id_categoria).HasColumnName("ID_CATEGORIA");
            Property(p => p.nomb_categoria).HasColumnName("NOMB_CATEGORIA").HasMaxLength(250);
        }
    }
}