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
    
    public partial class birthdate_books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public birthdate_books()
        {
            this.date_orders = new HashSet<date_orders>();
        }
    
        public int id { get; set; }
        public string bookname { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public short price { get; set; }
        public string publisher { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<date_orders> date_orders { get; set; }
    }
}