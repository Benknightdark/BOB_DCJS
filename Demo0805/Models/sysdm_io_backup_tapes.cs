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
    
    public partial class sysdm_io_backup_tapes
    {
        public string physical_device_name { get; set; }
        public string logical_device_name { get; set; }
        public int status { get; set; }
        public string status_desc { get; set; }
        public Nullable<System.DateTime> mount_request_time { get; set; }
        public Nullable<System.DateTime> mount_expiration_time { get; set; }
        public string database_name { get; set; }
        public Nullable<int> spid { get; set; }
        public Nullable<int> command { get; set; }
        public string command_desc { get; set; }
        public Nullable<int> media_family_id { get; set; }
        public string media_set_name { get; set; }
        public Nullable<System.Guid> media_set_guid { get; set; }
        public Nullable<int> media_sequence_number { get; set; }
        public Nullable<int> tape_operation { get; set; }
        public string tape_operation_desc { get; set; }
        public Nullable<int> mount_request_type { get; set; }
        public string mount_request_type_desc { get; set; }
    }
}
