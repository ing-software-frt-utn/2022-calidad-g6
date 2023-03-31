using Dominio.Entidades;
using Dominio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Contexto
{
    public class ContextoControlCalidad : DbContext
    {

        public ContextoControlCalidad() : base (nameOrConnectionString: "name=ControlCalidadDb")
        {

        }

        public ContextoControlCalidad(bool conectarADBTest) : base("Data Source=localhost;Initial Catalog= ControlCalidadDb ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();
            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder
                .Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder
                .Entity<ClaseUsuario>()
                .ToTable("ClasesUsuario")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<CategoriaDefecto>()
                .ToTable("CategoriasDefecto")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<LineaDeTrabajo>()
                .ToTable("LineasDeTrabajo")
                .Property(x => x.NumeroDeLinea)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<ClaseIncidencia>()
                .ToTable("ClasesIncidencia")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<EstadoOP>()
                .ToTable("EstadosOP")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<Pie>()
                .ToTable("Pies")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<Usuario>()
                .ToTable("Usuarios")
                .Property(x => x.Dni)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<Usuario>()
                .ToTable("Usuarios")
                .Property(x => x.CuentaDeUsuario)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index2", new IndexAnnotation(new[] { new IndexAttribute("Index2") { IsUnique = true } }));


            modelBuilder
                .Entity<Turno>()
                .ToTable("Turnos")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<Alerta>()
                .ToTable("Alertas")
                .HasRequired(a => a.Dueno)
                .WithMany(o => o.Alertas);

            modelBuilder
                .Entity<OrdenDeProduccion>()
                .ToTable("OrdenesDeProduccion")
                .Property(x => x.NumeroOP)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<OrdenDeProduccion>()
                .ToTable("OrdenesDeProduccion")
                .Property(x => x.FechaFin)
                .IsOptional();

            modelBuilder
                .Entity<OrdenDeProduccion>()
                .ToTable("OrdenesDeProduccion")
                .Property(x => x.UsuarioId)
                .IsOptional();

            modelBuilder
                .Entity<OrdenDeProduccion>()
                .ToTable("OrdenesDeProduccion")
                .HasIndex(x => x.NumeroOP)
                .IsUnique();

            modelBuilder
                .Entity<Color>()
                .ToTable("Colores")
                .Property(x => x.Codigo)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<Defecto>()
                .ToTable("Defectos");


            modelBuilder
                .Entity<Modelo>()
                .ToTable("Modelos")
                .Property(x => x.SKU)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<EstadoDeUso>()
                .ToTable("EstadosDeUso")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<EstadoDeLinea>()
                .ToTable("EstadosDeLinea")
                .Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

            modelBuilder
                .Entity<JornadaLaboral>()
                .ToTable("JornadasLaborales")
                .HasRequired(x => x.Dueno)
                .WithMany(j => j.JornadasLaborales)
                .WillCascadeOnDelete(true);

            modelBuilder
                .Entity<Incidencia>()
                .ToTable("Incidencias")
                .HasRequired(x => x.Dueno)
                .WithMany(i => i.Incidencias)
                .WillCascadeOnDelete(true);
            modelBuilder
                .Entity<Incidencia>()
                .ToTable("Incidencias")
                .Property(x => x.DefectoId)
                .IsOptional();

            modelBuilder
                .Entity<Incidencia>()
                .ToTable("Incidencias")
                .Property(x => x.PieId)
                .IsOptional();

            modelBuilder
                .Entity<EstadoSemaforo>()
                .ToTable("EstadosSemaforo");

            modelBuilder
                .Entity<Semaforo>()
                .ToTable("Semaforos")
                .HasRequired(x => x.Linea);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<ClaseUsuario> ClasesUsuario { get; set; }

        public DbSet<CategoriaDefecto> CategoriasDefecto { get; set; }

        public DbSet<LineaDeTrabajo> LineasDeTrabajo { get; set; }

        public DbSet<ClaseIncidencia> ClasesIncidencia { get; set; }

        public DbSet<EstadoOP> EstadosOP { get; set; }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Turno> Turnos { get; set; }

        public DbSet<Alerta> Alertas { get; set; }

        public DbSet<OrdenDeProduccion> OrdenesDeProduccion { get; set; }

        public DbSet<Color> Colores { get; set; }

        public DbSet<Defecto> Defectos { get; set; }

        public DbSet<Incidencia> Incidencias { get; set; }

        public DbSet<JornadaLaboral> JornadasLaborales { get; set; }

        public DbSet<Modelo> Modelos { get; set; }

        public DbSet<EstadoDeUso> EstadosDeUso { get; set; }

        public DbSet<EstadoDeLinea> EstadosDeLinea { get; set; }

        public DbSet<EstadoSemaforo> EstadosSemaforo { get; set; }

        public DbSet<Semaforo> Semaforos { get; set; }

    }
}
