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
    
    public partial class order
    {
        [Required]
        [Display(Name = "書店編號")]
        public long? no { get; set; }
        [Required]
        [Display(Name = "書籍編號")]
        public long? id { get; set; }
        [Required]
        [Display(Name = "書籍存貨數量")]
        public Nullable<int> quantity { get; set; }
    
        public virtual book book { get; set; }
        public virtual bookstore bookstore { get; set; }
    }
}
