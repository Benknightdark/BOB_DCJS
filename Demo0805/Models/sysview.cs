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
    
    public partial class sysview
    {
        public string name { get; set; }
        public int object_id { get; set; }
        public Nullable<int> principal_id { get; set; }
        public int schema_id { get; set; }
        public int parent_object_id { get; set; }
        public string type { get; set; }
        public string type_desc { get; set; }
        public System.DateTime create_date { get; set; }
        public System.DateTime modify_date { get; set; }
        public bool is_ms_shipped { get; set; }
        public bool is_published { get; set; }
        public bool is_schema_published { get; set; }
        public Nullable<bool> is_replicated { get; set; }
        public Nullable<bool> has_replication_filter { get; set; }
        public bool has_opaque_metadata { get; set; }
        public bool has_unchecked_assembly_data { get; set; }
        public bool with_check_option { get; set; }
        public bool is_date_correlation_view { get; set; }
        public Nullable<bool> is_tracked_by_cdc { get; set; }
    }
}
