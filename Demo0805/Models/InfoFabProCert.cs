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
    
    public partial class InfoFabProCert
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoFabProCert()
        {
            this.InfoFabEmpProCerts = new HashSet<InfoFabEmpProCert>();
            this.InfoFabProCertSkills = new HashSet<InfoFabProCertSkill>();
        }
    
        public System.Guid ID { get; set; }
        public string CertName { get; set; }
        public string CertAgency { get; set; }
        public Nullable<System.Guid> DegreeTypeID { get; set; }
        public string CustomDegreeType { get; set; }
        public string Remark { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabCode InfoFabCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabEmpProCert> InfoFabEmpProCerts { get; set; }
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabProCertSkill> InfoFabProCertSkills { get; set; }
    }
}
