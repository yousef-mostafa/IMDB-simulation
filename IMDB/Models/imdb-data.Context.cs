﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IMDb_dataEntities : DbContext
    {
        public IMDb_dataEntities()
            : base("name=IMDb_dataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movy> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<user_comment> user_comment { get; set; }
    }
}