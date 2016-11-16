using NovaKidsControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaKids.Infra.Data.Context
{
    public class NovaKidsContext : DbContext 
    {
        public NovaKidsContext(): base("NovaKidsContext")
        {

        }

        //public DbSet<Crianca> Criancas { get; set; }
        //public DbSet<Professor> Professores { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
        public DbSet<UserKids> UserKids { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<UserKids>().ToTable("UserKids");
            modelBuilder.Entity<Professor>().ToTable("Professores");
            modelBuilder.Entity<Crianca>().ToTable("Criancas");
            base.OnModelCreating(modelBuilder);
        }


    }
}
