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
    
    public partial class sysdm_os_worker_local_storage
    {
        public byte[] worker_address { get; set; }
        public byte[] comp_exec_ctxt_address { get; set; }
        public byte[] ec_address { get; set; }
        public byte[] broker_address { get; set; }
        public byte[] task_proxy_address { get; set; }
        public byte[] msqlxact_address { get; set; }
        public byte[] sql_prof_address { get; set; }
        public byte[] stack_checker_address { get; set; }
        public byte[] host_task_address { get; set; }
        public byte[] sni_error_address { get; set; }
        public byte[] queryscan_address { get; set; }
        public byte[] diag_address { get; set; }
    }
}