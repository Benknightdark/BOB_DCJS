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
    
    public partial class sysdatabase_mirroring_witnesses
    {
        public string database_name { get; set; }
        public string principal_server_name { get; set; }
        public string mirror_server_name { get; set; }
        public byte safety_level { get; set; }
        public string safety_level_desc { get; set; }
        public int safety_sequence_number { get; set; }
        public int role_sequence_number { get; set; }
        public System.Guid mirroring_guid { get; set; }
        public System.Guid family_guid { get; set; }
        public Nullable<bool> is_suspended { get; set; }
        public int is_suspended_sequence_number { get; set; }
        public Nullable<byte> partner_sync_state { get; set; }
        public string partner_sync_state_desc { get; set; }
    }
}