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
    
    public partial class syssysdepend
    {
        public int id { get; set; }
        public int depid { get; set; }
        public Nullable<short> number { get; set; }
        public Nullable<short> depnumber { get; set; }
        public Nullable<short> status { get; set; }
        public byte deptype { get; set; }
        public Nullable<short> depdbid { get; set; }
        public Nullable<short> depsiteid { get; set; }
        public bool selall { get; set; }
        public bool resultobj { get; set; }
        public bool readobj { get; set; }
    }
}
