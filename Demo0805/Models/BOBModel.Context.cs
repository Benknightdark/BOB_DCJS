﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo0805.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BOBEntities : DbContext
    {
        public BOBEntities()
            : base("name=BOBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<birthdate_books> birthdate_books { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<bookstore> bookstores { get; set; }
        public virtual DbSet<date_orders> date_orders { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Num> Nums { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<Product_Name> Product_Name { get; set; }
        public virtual DbSet<Product_Property> Product_Property { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesManager> SalesManagers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ToBeUpdated> ToBeUpdateds { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<XMLBook> XMLBooks { get; set; }
        public virtual DbSet<Zipdata> Zipdatas { get; set; }
        public virtual DbSet<xml_tab> xml_tab { get; set; }
        public virtual DbSet<CD音樂> CD音樂 { get; set; }
        public virtual DbSet<Mbook> Mbooks { get; set; }
        public virtual DbSet<Month_Sales> Month_Sales { get; set; }
        public virtual DbSet<Nbook> Nbooks { get; set; }
        public virtual DbSet<PV> PVs { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<書籍> 書籍 { get; set; }
        public virtual DbSet<LogonModel> LogonModels { get; set; }
    }
}
