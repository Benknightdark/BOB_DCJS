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
    
    public partial class SalesManager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesManager()
        {
            this.Sales = new HashSet<Sale>();
            this.SalesManagers1 = new HashSet<SalesManager>();
        }
    
        public string eno { get; set; }
        public string name { get; set; }
        public string manager { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesManager> SalesManagers1 { get; set; }
        public virtual SalesManager SalesManager1 { get; set; }
    }
}