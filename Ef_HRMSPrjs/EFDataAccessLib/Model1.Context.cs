﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDataAccessLib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoDBEntities : DbContext
    {
        public DemoDBEntities()
            : base("name=DemoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<dept> depts { get; set; }
        public virtual DbSet<tbl_employee> tbl_employee { get; set; }
    
        public virtual int sp_updateemp(Nullable<int> ec, Nullable<int> sal)
        {
            var ecParameter = ec.HasValue ?
                new ObjectParameter("ec", ec) :
                new ObjectParameter("ec", typeof(int));
    
            var salParameter = sal.HasValue ?
                new ObjectParameter("sal", sal) :
                new ObjectParameter("sal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateemp", ecParameter, salParameter);
        }
    }
}
