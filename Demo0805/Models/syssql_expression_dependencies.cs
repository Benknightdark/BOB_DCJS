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
    
    public partial class syssql_expression_dependencies
    {
        public int referencing_id { get; set; }
        public int referencing_minor_id { get; set; }
        public Nullable<byte> referencing_class { get; set; }
        public string referencing_class_desc { get; set; }
        public bool is_schema_bound_reference { get; set; }
        public Nullable<byte> referenced_class { get; set; }
        public string referenced_class_desc { get; set; }
        public string referenced_server_name { get; set; }
        public string referenced_database_name { get; set; }
        public string referenced_schema_name { get; set; }
        public string referenced_entity_name { get; set; }
        public Nullable<int> referenced_id { get; set; }
        public int referenced_minor_id { get; set; }
        public bool is_caller_dependent { get; set; }
        public bool is_ambiguous { get; set; }
    }
}