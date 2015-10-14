//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class JJMFTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JJMFTask()
        {
            this.JJMFEmpProcedures = new HashSet<JJMFEmpProcedure>();
            this.JJMFEmpTaskDailyDisplays = new HashSet<JJMFEmpTaskDailyDisplay>();
            this.JJMFEmpTaskDailyRecords = new HashSet<JJMFEmpTaskDailyRecord>();
            this.JJMFTaskCals = new HashSet<JJMFTaskCal>();
            this.JJMFTaskInternalProcs = new HashSet<JJMFTaskInternalProc>();
        }
    
        public System.Guid ID { get; set; }
        public string TaskCode { get; set; }
        public string Title { get; set; }
        public System.Guid TaskStatus { get; set; }
        public string Description { get; set; }
        public string Attachfiles { get; set; }
        public Nullable<System.Guid> Owner { get; set; }
        public string Coworker { get; set; }
        public Nullable<System.DateTime> CalSDate { get; set; }
        public Nullable<System.DateTime> CalEDate { get; set; }
        public bool Copyable { get; set; }
        public Nullable<System.Guid> SkillTypeID { get; set; }
        public Nullable<System.Guid> FPID { get; set; }
        public bool IsInternal { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabCode InfoFabCode { get; set; }
        public virtual InfoFabEmpOrg InfoFabEmpOrg { get; set; }
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        public virtual InfoFabSkillType InfoFabSkillType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JJMFEmpProcedure> JJMFEmpProcedures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JJMFEmpTaskDailyDisplay> JJMFEmpTaskDailyDisplays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JJMFEmpTaskDailyRecord> JJMFEmpTaskDailyRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JJMFTaskCal> JJMFTaskCals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JJMFTaskInternalProc> JJMFTaskInternalProcs { get; set; }
    }
}
