﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimiento_Chris
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConexionComedorEntities : DbContext
    {
        public ConexionComedorEntities()
            : base("name=ConexionComedorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comedor> Comedor { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Platillo> Platillo { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proovedores> Proovedores { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
    }
}