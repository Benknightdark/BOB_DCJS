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
    
    public partial class syssyscacheobject
    {
        public int bucketid { get; set; }
        public string cacheobjtype { get; set; }
        public string objtype { get; set; }
        public Nullable<int> objid { get; set; }
        public Nullable<short> dbid { get; set; }
        public Nullable<short> dbidexec { get; set; }
        public Nullable<short> uid { get; set; }
        public int refcounts { get; set; }
        public int usecounts { get; set; }
        public Nullable<int> pagesused { get; set; }
        public Nullable<int> setopts { get; set; }
        public Nullable<short> langid { get; set; }
        public Nullable<short> dateformat { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> lasttime { get; set; }
        public Nullable<long> maxexectime { get; set; }
        public Nullable<long> avgexectime { get; set; }
        public Nullable<long> lastreads { get; set; }
        public Nullable<long> lastwrites { get; set; }
        public Nullable<int> sqlbytes { get; set; }
        public string sql { get; set; }
    }
}
