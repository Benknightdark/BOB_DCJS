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
    
    public partial class sysdm_os_schedulers
    {
        public byte[] scheduler_address { get; set; }
        public int parent_node_id { get; set; }
        public int scheduler_id { get; set; }
        public int cpu_id { get; set; }
        public string status { get; set; }
        public bool is_online { get; set; }
        public bool is_idle { get; set; }
        public int preemptive_switches_count { get; set; }
        public int context_switches_count { get; set; }
        public int idle_switches_count { get; set; }
        public int current_tasks_count { get; set; }
        public int runnable_tasks_count { get; set; }
        public int current_workers_count { get; set; }
        public int active_workers_count { get; set; }
        public long work_queue_count { get; set; }
        public int pending_disk_io_count { get; set; }
        public int load_factor { get; set; }
        public int yield_count { get; set; }
        public long last_timer_activity { get; set; }
        public bool failed_to_create_worker { get; set; }
        public byte[] active_worker_address { get; set; }
        public byte[] memory_object_address { get; set; }
        public byte[] task_memory_object_address { get; set; }
        public long quantum_length_us { get; set; }
    }
}
