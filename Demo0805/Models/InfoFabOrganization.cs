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
    
    public partial class InfoFabOrganization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoFabOrganization()
        {
            this.InfoFabEmpOrgs = new HashSet<InfoFabEmpOrg>();
            this.InfoFabOrganization1 = new HashSet<InfoFabOrganization>();
            this.InfoFabOrgEnvs = new HashSet<InfoFabOrgEnv>();
            this.InfoFabOrgEnvs1 = new HashSet<InfoFabOrgEnv>();
            this.InfoFabOrgEnvs2 = new HashSet<InfoFabOrgEnv>();
        }
    
        public System.Guid ID { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string AliasName { get; set; }
        public System.Guid OrgLevel { get; set; }
        public Nullable<System.Guid> LeaderEmpOrgID { get; set; }
        public Nullable<System.Guid> PID { get; set; }
        public string PIDs { get; set; }
        public System.DateTime EffectDate { get; set; }
        public string UnifiedBusinessNo { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string BusinessLines { get; set; }
        public string CostCenter { get; set; }
        public bool IsEnabled { get; set; }
        public string Remark { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabCode InfoFabCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabEmpOrg> InfoFabEmpOrgs { get; set; }
        public virtual InfoFabEmpOrg InfoFabEmpOrg { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabOrganization> InfoFabOrganization1 { get; set; }
        public virtual InfoFabOrganization InfoFabOrganization2 { get; set; }
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabOrgEnv> InfoFabOrgEnvs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabOrgEnv> InfoFabOrgEnvs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoFabOrgEnv> InfoFabOrgEnvs2 { get; set; }
    }
}