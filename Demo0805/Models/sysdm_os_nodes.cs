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
    
    public partial class sysdm_os_nodes
    {
        public short node_id { get; set; }
        public string node_state_desc { get; set; }
        public byte[] memory_object_address { get; set; }
        public byte[] memory_clerk_address { get; set; }
        public byte[] io_completion_worker_address { get; set; }
        public short memory_node_id { get; set; }
        public long cpu_affinity_mask { get; set; }
        public short online_scheduler_count { get; set; }
        public short idle_scheduler_count { get; set; }
        public int active_worker_count { get; set; }
        public int avg_load_balance { get; set; }
        public long timer_task_affinity_mask { get; set; }
        public long permanent_task_affinity_mask { get; set; }
        public bool resource_monitor_state { get; set; }
        public long online_scheduler_mask { get; set; }
        public short processor_group { get; set; }
    }
}