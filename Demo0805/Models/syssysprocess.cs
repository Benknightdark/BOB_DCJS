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
    
    public partial class syssysprocess
    {
        public short spid { get; set; }
        public short kpid { get; set; }
        public short blocked { get; set; }
        public byte[] waittype { get; set; }
        public long waittime { get; set; }
        public string lastwaittype { get; set; }
        public string waitresource { get; set; }
        public short dbid { get; set; }
        public Nullable<short> uid { get; set; }
        public int cpu { get; set; }
        public long physical_io { get; set; }
        public int memusage { get; set; }
        public System.DateTime login_time { get; set; }
        public System.DateTime last_batch { get; set; }
        public short ecid { get; set; }
        public short open_tran { get; set; }
        public string status { get; set; }
        public byte[] sid { get; set; }
        public string hostname { get; set; }
        public string program_name { get; set; }
        public string hostprocess { get; set; }
        public string cmd { get; set; }
        public string nt_domain { get; set; }
        public string nt_username { get; set; }
        public string net_address { get; set; }
        public string net_library { get; set; }
        public string loginame { get; set; }
        public byte[] context_info { get; set; }
        public byte[] sql_handle { get; set; }
        public int stmt_start { get; set; }
        public int stmt_end { get; set; }
        public int request_id { get; set; }
    }
}
