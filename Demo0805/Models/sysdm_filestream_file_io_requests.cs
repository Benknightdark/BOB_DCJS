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
    
    public partial class sysdm_filestream_file_io_requests
    {
        public byte[] request_context_address { get; set; }
        public short current_spid { get; set; }
        public string request_type { get; set; }
        public string request_state { get; set; }
        public int request_id { get; set; }
        public int irp_id { get; set; }
        public int handle_id { get; set; }
        public byte[] client_thread_id { get; set; }
        public byte[] client_process_id { get; set; }
        public byte[] handle_context_address { get; set; }
        public byte[] filestream_transaction_id { get; set; }
    }
}
