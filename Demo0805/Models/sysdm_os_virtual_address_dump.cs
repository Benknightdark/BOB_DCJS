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
    
    public partial class sysdm_os_virtual_address_dump
    {
        public byte[] region_base_address { get; set; }
        public byte[] region_allocation_base_address { get; set; }
        public byte[] region_allocation_protection { get; set; }
        public long region_size_in_bytes { get; set; }
        public byte[] region_state { get; set; }
        public byte[] region_current_protection { get; set; }
        public byte[] region_type { get; set; }
    }
}