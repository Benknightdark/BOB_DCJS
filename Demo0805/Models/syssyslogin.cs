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
    
    public partial class syssyslogin
    {
        public byte[] sid { get; set; }
        public Nullable<short> status { get; set; }
        public System.DateTime createdate { get; set; }
        public System.DateTime updatedate { get; set; }
        public System.DateTime accdate { get; set; }
        public Nullable<int> totcpu { get; set; }
        public Nullable<int> totio { get; set; }
        public Nullable<int> spacelimit { get; set; }
        public Nullable<int> timelimit { get; set; }
        public Nullable<int> resultlimit { get; set; }
        public string name { get; set; }
        public string dbname { get; set; }
        public string password { get; set; }
        public string language { get; set; }
        public Nullable<int> denylogin { get; set; }
        public Nullable<int> hasaccess { get; set; }
        public Nullable<int> isntname { get; set; }
        public Nullable<int> isntgroup { get; set; }
        public Nullable<int> isntuser { get; set; }
        public Nullable<int> sysadmin { get; set; }
        public Nullable<int> securityadmin { get; set; }
        public Nullable<int> serveradmin { get; set; }
        public Nullable<int> setupadmin { get; set; }
        public Nullable<int> processadmin { get; set; }
        public Nullable<int> diskadmin { get; set; }
        public Nullable<int> dbcreator { get; set; }
        public Nullable<int> bulkadmin { get; set; }
        public string loginname { get; set; }
    }
}