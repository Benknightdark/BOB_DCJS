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
    
    public partial class InfoFabEmpLeave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoFabEmpLeave()
        {
            this.InfoFabEmpLeaveDays = new HashSet<InfoFabEmpLeaveDay>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid EmpOrgID { get; set; }
        public bool DependOnPublic { get; set; }
        public Nullable<System.DateTime> SDateTime { get; set; }
        public Nullable<System.DateTime> EDateTime { get; set; }
        public Nullable<decimal> LeaveHours { get; set; }
        public Nullable<System.Guid> LeaveCodeID { get; set; }
        public System.Guid LeaveDeputyType { get; set; }
        public Nullable<System.Guid> DeputyEmpOrgID { get; set; }
        public bool IsSubstituteSignEnabled { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> WorkCodeID { get; set; }
        public Nullable<System.Guid> FPID { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabCode InfoFabCode { get; set; }
        public virtual InfoFabEmpOrg InfoFabEmpOrg { get; set; }
        public virtual InfoFabEmpOrg InfoFabEmpOrg1 { get; set; }
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        public virtual InfoFabLeaveCode InfoFabLeaveCode { get; set; }
        public virtual InfoFabWorkCode InfoFabWorkCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabEmpLeaveDay> InfoFabEmpLeaveDays { get; set; }
    }
}
