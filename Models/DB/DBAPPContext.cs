using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
    public class DBAPPContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Config> Config { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlite(connectionString: "Filename=AppDB.db",
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            base.OnConfiguring(optionsbuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Usuarios");
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });

            modelBuilder.Entity<Turno>().ToTable("Turnos");
            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.TurnoId);
            });

            modelBuilder.Entity<Venta>().ToTable("Ventas");
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.VentaId);
            });

            modelBuilder.Entity<Config>().ToTable("Configs");
            modelBuilder.Entity<Config>(entity =>
            {
                entity.HasKey(e => e.ConfigId);
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
