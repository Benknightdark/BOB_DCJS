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
    
    public partial class sysservice_contract_message_usages
    {
        public int service_contract_id { get; set; }
        public int message_type_id { get; set; }
        public bool is_sent_by_initiator { get; set; }
        public bool is_sent_by_target { get; set; }
    }
}
