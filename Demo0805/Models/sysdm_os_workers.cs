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
    
    public partial class sysdm_os_workers
    {
        public byte[] worker_address { get; set; }
        public int status { get; set; }
        public Nullable<bool> is_preemptive { get; set; }
        public Nullable<bool> is_fiber { get; set; }
        public Nullable<bool> is_sick { get; set; }
        public Nullable<bool> is_in_cc_exception { get; set; }
        public Nullable<bool> is_fatal_exception { get; set; }
        public Nullable<bool> is_inside_catch { get; set; }
        public Nullable<bool> is_in_polling_io_completion_routine { get; set; }
        public int context_switch_count { get; set; }
        public int pending_io_count { get; set; }
        public long pending_io_byte_count { get; set; }
        public int pending_io_byte_average { get; set; }
        public long wait_started_ms_ticks { get; set; }
        public long wait_resumed_ms_ticks { get; set; }
        public long task_bound_ms_ticks { get; set; }
        public long worker_created_ms_ticks { get; set; }
        public int exception_num { get; set; }
        public int exception_severity { get; set; }
        public byte[] exception_address { get; set; }
        public int locale { get; set; }
        public long affinity { get; set; }
        public string state { get; set; }
        public long start_quantum { get; set; }
        public long end_quantum { get; set; }
        public string last_wait_type { get; set; }
        public int return_code { get; set; }
        public long quantum_used { get; set; }
        public long max_quantum { get; set; }
        public int boost_count { get; set; }
        public int tasks_processed_count { get; set; }
        public byte[] fiber_address { get; set; }
        public byte[] task_address { get; set; }
        public byte[] memory_object_address { get; set; }
        public byte[] thread_address { get; set; }
        public byte[] signal_worker_address { get; set; }
        public byte[] scheduler_address { get; set; }
        public short processor_group { get; set; }
    }
}
