﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.EFMODEL.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LISEntities : DbContext
    {
        public LISEntities()
            : base("name=LISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<LIS_ANTIBIOTIC> LIS_ANTIBIOTIC { get; set; }
        public DbSet<LIS_BAC_ANTIBIOTIC> LIS_BAC_ANTIBIOTIC { get; set; }
        public DbSet<LIS_BACTERIUM> LIS_BACTERIUM { get; set; }
        public DbSet<LIS_BACTERIUM_FAMILY> LIS_BACTERIUM_FAMILY { get; set; }
        public DbSet<LIS_BARCODE> LIS_BARCODE { get; set; }
        public DbSet<LIS_CONFIG> LIS_CONFIG { get; set; }
        public DbSet<LIS_MACHINE> LIS_MACHINE { get; set; }
        public DbSet<LIS_MACHINE_INDEX> LIS_MACHINE_INDEX { get; set; }
        public DbSet<LIS_ORDINAL> LIS_ORDINAL { get; set; }
        public DbSet<LIS_RESULT> LIS_RESULT { get; set; }
        public DbSet<LIS_SAMPLE> LIS_SAMPLE { get; set; }
        public DbSet<LIS_SAMPLE_CONDITION> LIS_SAMPLE_CONDITION { get; set; }
        public DbSet<LIS_SAMPLE_SERVICE> LIS_SAMPLE_SERVICE { get; set; }
        public DbSet<LIS_SAMPLE_SERVICE_STT> LIS_SAMPLE_SERVICE_STT { get; set; }
        public DbSet<LIS_SAMPLE_STT> LIS_SAMPLE_STT { get; set; }
        public DbSet<LIS_SAMPLE_TYPE> LIS_SAMPLE_TYPE { get; set; }
        public DbSet<LIS_TEST_INDEX_MAP> LIS_TEST_INDEX_MAP { get; set; }
        public DbSet<V_LIS_BAC_ANTIBIOTIC> V_LIS_BAC_ANTIBIOTIC { get; set; }
        public DbSet<V_LIS_RESULT> V_LIS_RESULT { get; set; }
        public DbSet<V_LIS_SAMPLE> V_LIS_SAMPLE { get; set; }
        public DbSet<V_LIS_SAMPLE_SERVICE> V_LIS_SAMPLE_SERVICE { get; set; }
        public DbSet<V_LIS_TEST_INDEX_MAP> V_LIS_TEST_INDEX_MAP { get; set; }
    }
}