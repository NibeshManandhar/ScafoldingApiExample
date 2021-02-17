using System;
using System.Collections.Generic;

#nullable disable

namespace PrabeshWebApi.Models
{
    public partial class Employee
    {
        public int Employee1 { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public DateTime? DateofJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
