using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TaskManagement.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Tasks = new HashSet<_Task>();
        }
        [Key]
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<_Task> Tasks { get; set; }
    }
}
