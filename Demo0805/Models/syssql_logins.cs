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
    
    public partial class syssql_logins
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        public byte[] sid { get; set; }
        public string type { get; set; }
        public string type_desc { get; set; }
        public Nullable<bool> is_disabled { get; set; }
        public System.DateTime create_date { get; set; }
        public System.DateTime modify_date { get; set; }
        public string default_database_name { get; set; }
        public string default_language_name { get; set; }
        public Nullable<int> credential_id { get; set; }
        public Nullable<bool> is_policy_checked { get; set; }
        public Nullable<bool> is_expiration_checked { get; set; }
        public byte[] password_hash { get; set; }
    }
}