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
    
    public partial class sysall_parameters
    {
        public int object_id { get; set; }
        public string name { get; set; }
        public int parameter_id { get; set; }
        public byte system_type_id { get; set; }
        public int user_type_id { get; set; }
        public short max_length { get; set; }
        public byte precision { get; set; }
        public byte scale { get; set; }
        public bool is_output { get; set; }
        public bool is_cursor_ref { get; set; }
        public bool has_default_value { get; set; }
        public bool is_xml_document { get; set; }
        public int xml_collection_id { get; set; }
        public bool is_readonly { get; set; }
    }
}
