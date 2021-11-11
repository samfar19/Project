using System;
using System.Collections.Generic;

#nullable disable

namespace Projects.Models
{
    public class _Task
    {

        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ESTHours { get; set; }
        public int Completion { get; set; }
        public Boolean Done { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        
        //public virtual Employee Employee { get; set; }

    }
}

