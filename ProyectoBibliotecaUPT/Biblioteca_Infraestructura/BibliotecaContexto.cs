using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Dominio.Entidades;
using Biblioteca_Infraestructura.Mapeos;
using System.Data.Entity;

namespace Biblioteca_Infraestructura
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto() : base("BiblioBD") { }

        public DbSet<ClsAutor> clsAutors { get; set; }
        public DbSet<ClsCategoria> clsCategorias { get; set; }
        public DbSet<ClsEditorial> clsEditorials { get; set; }
        public DbSet<ClsEdicion> clsEdicions { get; set; }
        public DbSet<ClsEjemplar> clsEjemplars { get; set; }
        public DbSet<ClsFavorito> clsFavoritos { get; set; }
        public DbSet<ClsHistorial> clsHistorials { get; set; }
        public DbSet<ClsLibro> clsLibros { get; set; }
        public DbSet<ClsPersona> clsPersonas { get; set; }
        public DbSet<ClsPrestamo> clsPrestamos { get; set; }
        public DbSet<ClsRanking> clsRankings { get; set; }
        public DbSet<ClsReserva> clsReservas { get; set; }
        public DbSet<ClsTipoUsuario> clsTipoUsuarios { get; set; }
        public DbSet<ClsUsuario> clsUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AutorMapeo());
            modelBuilder.Configurations.Add(new CategoriaMapeo());
            modelBuilder.Configurations.Add(new EdicionMapeo());
            modelBuilder.Configurations.Add(new EditorialMapeo());
            modelBuilder.Configurations.Add(new EjemplarMapeo());
            modelBuilder.Configurations.Add(new FavoritoMapeo());
            modelBuilder.Configurations.Add(new HistorialMapeo());
            modelBuilder.Configurations.Add(new LibroMapeo());
            modelBuilder.Configurations.Add(new PersonaMapeo());
            modelBuilder.Configurations.Add(new PrestamoMapeo());
            modelBuilder.Configurations.Add(new RankingMapeo());
            modelBuilder.Configurations.Add(new ReservaMapeo());
            modelBuilder.Configurations.Add(new TipoUsuarioMapeo());
            modelBuilder.Configurations.Add(new UsuarioMapeo());
        }
    }
}
