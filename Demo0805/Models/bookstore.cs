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
    using System.ComponentModel.DataAnnotations;
    
    public partial class bookstore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bookstore()
        {
            this.orders = new HashSet<order>();
        }
        [Display(ResourceType = typeof(L10N.Resource), Name = "no")]
        [Required]
        public long no { get; set; }
        [Display(ResourceType = typeof(L10N.Resource), Name = "name")]
        [Required]
        public string name { get; set; }
        [Display(ResourceType = typeof(L10N.Resource), Name = "rank")]
        [Required]
        public Nullable<long> rank { get; set; }
        [Display(ResourceType = typeof(L10N.Resource), Name = "city")]
        [Required]
        public string city { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
