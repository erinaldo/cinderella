﻿using Common.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public class CommonContext : DbContext
    {
        public CommonContext()
        : base("SistemaCinderella.My.MySettings.Conexion")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Banco> Banco { get; set; }

        public DbSet<ClienteMayorista> ClienteMayorista { get; set; }

        public DbSet<Feriado> Feriado { get; set; }

        public DbSet<Domicilio> Domicilio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Banco>().ToTable("BANCOS");
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Banco>().Property(t => t.Id).HasColumnName("BancoId");

            modelBuilder.Entity<ClienteMayorista>().ToTable("CLIENTEMAYORISTA");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.Id).HasColumnName("id_Cliente");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.CondicionIVA).HasColumnName("id_CondicionIva");
            modelBuilder.Entity<ClienteMayorista>().Property(t => t.IdDireccionFacturacion).HasColumnName("id_DireccionFacturacion");
            modelBuilder.Entity<ClienteMayorista>().HasOptional(v => v.DomicilioFacturacion).WithMany().HasForeignKey(x => x.IdDireccionFacturacion);

            modelBuilder.Entity<Feriado>().ToTable("FERIADOS");
            modelBuilder.Entity<Feriado>().Property(t => t.Id).HasColumnName("id_Feriado");
            modelBuilder.Entity<Feriado>().Property(t => t.Fecha).HasColumnName("FechaCorta");

            modelBuilder.Entity<Domicilio>().ToTable("DIRECCION");
            modelBuilder.Entity<Domicilio>().Property(t => t.Id).HasColumnName("id_Direccion");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdLocalidad).HasColumnName("id_Localidad");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdDistrito).HasColumnName("id_Distrito");
            modelBuilder.Entity<Domicilio>().Property(t => t.IdProvincia).HasColumnName("id_Provincia");
            modelBuilder.Entity<Domicilio>().Property(t => t.Email).HasColumnName("Mail");
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Localidad).WithMany().HasForeignKey(x => x.IdLocalidad);
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Distrito).WithMany().HasForeignKey(x => x.IdDistrito);
            modelBuilder.Entity<Domicilio>().HasRequired(v => v.Provincia).WithMany().HasForeignKey(x => x.IdProvincia);

            modelBuilder.Entity<Distrito>().ToTable("DEPARTAMENTOS");
            modelBuilder.Entity<Distrito>().Property(t => t.Id).HasColumnName("id_Departamento");

            modelBuilder.Entity<Localidad>().ToTable("LOCALIDADES");
            modelBuilder.Entity<Localidad>().Property(t => t.Id).HasColumnName("id_Localidad");

            modelBuilder.Entity<Provincia>().ToTable("PROVINCIAS");
            modelBuilder.Entity<Provincia>().Property(t => t.Id).HasColumnName("id_Provincia");

            base.OnModelCreating(modelBuilder);
        }
    }
}
