﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IzePay.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IZEPAYEntities : DbContext
    {
        public IZEPAYEntities()
            : base("name=IZEPAYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arrear> Arrears { get; set; }
        public virtual DbSet<Bonus> Bonuses { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}