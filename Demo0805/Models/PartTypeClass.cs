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
    
    public partial class PartTypeClass
    {
        public System.Guid ID { get; set; }
        public System.Guid PartTypeID { get; set; }
        public int SeqNo { get; set; }
        public int Length { get; set; }
        public bool IsPartNoCode { get; set; }
        public bool IsMandatory { get; set; }
        public System.Guid LovKindID { get; set; }
        public string LovKindValue { get; set; }
        public string InitUID { get; set; }
        public System.DateTime InitDT { get; set; }
        public string ModifiedUID { get; set; }
        public System.DateTime ModifiedDT { get; set; }
    
        public virtual InfoFabUser InfoFabUser { get; set; }
        public virtual InfoFabUser InfoFabUser1 { get; set; }
        public virtual PartLovKind PartLovKind { get; set; }
        public virtual PartType PartType { get; set; }
    }
}