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
    
    public partial class sysdm_os_sys_info
    {
        public long cpu_ticks { get; set; }
        public long ms_ticks { get; set; }
        public int cpu_count { get; set; }
        public int hyperthread_ratio { get; set; }
        public long physical_memory_in_bytes { get; set; }
        public long virtual_memory_in_bytes { get; set; }
        public int bpool_committed { get; set; }
        public int bpool_commit_target { get; set; }
        public int bpool_visible { get; set; }
        public int stack_size_in_bytes { get; set; }
        public long os_quantum { get; set; }
        public int os_error_mode { get; set; }
        public Nullable<int> os_priority_class { get; set; }
        public int max_workers_count { get; set; }
        public int scheduler_count { get; set; }
        public int scheduler_total_count { get; set; }
        public int deadlock_monitor_serial_number { get; set; }
        public long sqlserver_start_time_ms_ticks { get; set; }
        public System.DateTime sqlserver_start_time { get; set; }
        public int affinity_type { get; set; }
        public string affinity_type_desc { get; set; }
        public long process_kernel_time_ms { get; set; }
        public long process_user_time_ms { get; set; }
        public int time_source { get; set; }
        public string time_source_desc { get; set; }
        public int virtual_machine_type { get; set; }
        public string virtual_machine_type_desc { get; set; }
    }
}
