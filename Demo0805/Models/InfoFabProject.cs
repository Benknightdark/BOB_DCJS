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
    
    public partial class InfoFabProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoFabProject()
        {
            this.InfoFabProjectAttendees = new HashSet<InfoFabProjectAttendee>();
            this.InfoFabProjectClasses = new HashSet<InfoFabProjectClass>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid NodeID { get; set; }
        public string ProjectCode { get; set; }
        public System.Guid ProjectStatus { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Attachfiles { get; set; }
        public string Supervisor { get; set; }
        public bool Copyable { get; set; }
        public bool IsClosed { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabCode InfoFabCode { get; set; }
        public virtual InfoFabProjectNode InfoFabProjectNode { get; set; }
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        public virtual InfoFabUser InfoFabUser2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabProjectAttendee> InfoFabProjectAttendees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabProjectClass> InfoFabProjectClasses { get; set; }
    }
}