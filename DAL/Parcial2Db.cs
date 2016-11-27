using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;
namespace DAL
{
    public class Parcial2Db: DbContext
    {

        public Parcial2Db(): base ("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Cliente { get; set; }

        public virtual DbSet<TiposTelefonos> TipoTefefono { get; set; }

        public virtual DbSet<ClientesTelefonos> clienteTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                 .HasMany<Clientes>(c=> c.cliente)
                 .WithMany(t => t.Telefono)
                 .Map(ct =>
                 {
                     ct.MapLeftKey("ClineteId");
                     ct.MapRightKey("TipoId");
                     ct.ToTable("ClientesTelefonos");
                 });
        }
        
            
        }


 }





