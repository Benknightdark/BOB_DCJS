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
    
    public partial class systype
    {
        public string name { get; set; }
        public byte system_type_id { get; set; }
        public int user_type_id { get; set; }
        public int schema_id { get; set; }
        public Nullable<int> principal_id { get; set; }
        public short max_length { get; set; }
        public byte precision { get; set; }
        public byte scale { get; set; }
        public string collation_name { get; set; }
        public Nullable<bool> is_nullable { get; set; }
        public bool is_user_defined { get; set; }
        public bool is_assembly_type { get; set; }
        public int default_object_id { get; set; }
        public int rule_object_id { get; set; }
        public bool is_table_type { get; set; }
    }
}
