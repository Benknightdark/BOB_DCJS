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
    
    public partial class syskey_encryptions
    {
        public int key_id { get; set; }
        public byte[] thumbprint { get; set; }
        public string crypt_type { get; set; }
        public string crypt_type_desc { get; set; }
        public byte[] crypt_property { get; set; }
    }
}
