using System;
using System.Collections.Generic;

#nullable disable

namespace PrabeshWebApi.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public int? Marks { get; set; }
    }
}
