﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesarrolloWeb1Clase13.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class desarrolloEntities : DbContext
    {
        public desarrolloEntities()
            : base("name=desarrolloEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EstudianteHobbie> EstudianteHobbie { get; set; }
        public virtual DbSet<estudiente> estudiente { get; set; }
        public virtual DbSet<Hobbie> Hobbie { get; set; }
    }
}
