﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YoxaStudy.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiplomEntities : DbContext
    {
        public DiplomEntities()
            : base("name=DiplomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clothes> Clothes { get; set; }
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<StageOfTask> StageOfTask { get; set; }
        public virtual DbSet<Stajer> Stajer { get; set; }
        public virtual DbSet<StajerTask> StajerTask { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TypeMaterial> TypeMaterial { get; set; }
        public virtual DbSet<TypeUser> TypeUser { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Steps> Steps { get; set; }
        public virtual DbSet<StajerDay> StajerDay { get; set; }
        public virtual DbSet<StepTask> StepTask { get; set; }
    }
}
