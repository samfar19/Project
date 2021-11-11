using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TaskManagement.Models
{
    public partial class _Task
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Esthours { get; set; }
        public int? Completion { get; set; }
        public bool? Done { get; set; }
        public string Note { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
