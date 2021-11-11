using System;
using System.Collections.Generic;
using Projects.Models;

#nullable disable

namespace Projects.Models
{
    public  class Employee
    {
        public Employee()
        {
               Tasks = new HashSet<_Task>();
        }


        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
      //  public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        //public byte[] Photo { get; set; }


       public ICollection<_Task> Tasks { get; set; }
    }
}
