﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppExample.DataAccessLayer.Engine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebAppExample_EngineEntities : DbContext
    {
        public WebAppExample_EngineEntities()
            : base("name=WebAppExample_EngineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<n2mOrderDriver> n2mOrderDriver { get; set; }
        public virtual DbSet<tblAccount> tblAccount { get; set; }
        public virtual DbSet<tblCustomer> tblCustomer { get; set; }
        public virtual DbSet<tblDriver> tblDriver { get; set; }
        public virtual DbSet<tblEmployee> tblEmployee { get; set; }
        public virtual DbSet<tblOrder> tblOrder { get; set; }
        public virtual DbSet<tblVehicle> tblVehicle { get; set; }
        public virtual DbSet<vwOrderCustomer> vwOrderCustomer { get; set; }
    }
}
