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
    
    public partial class vwPeriodDataNormalCapacity_2
    {
        public System.Guid TaskID { get; set; }
        public string OrgCode { get; set; }
        public string OrgName { get; set; }
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Phase1ProcCode { get; set; }
        public string Phase1ProcName { get; set; }
        public string Phase2ProcCode { get; set; }
        public string Phase2ProcName { get; set; }
        public decimal CalQty { get; set; }
        public string TaskCode { get; set; }
        public string TaskTitle { get; set; }
        public Nullable<int> CalSDate_Year { get; set; }
        public Nullable<int> CalSDate_Month { get; set; }
        public Nullable<int> CalSDate_Day { get; set; }
        public Nullable<System.DateTime> CalSDate { get; set; }
        public Nullable<int> CalEDate_Year { get; set; }
        public Nullable<int> CalEDate_Month { get; set; }
        public Nullable<int> CalEDate_Day { get; set; }
        public Nullable<System.DateTime> CalEDate { get; set; }
        public System.Guid EmpOrgID { get; set; }
        public System.DateTime EmpOrgSDate { get; set; }
        public Nullable<System.DateTime> EmpOrgEDate { get; set; }
    }
}
