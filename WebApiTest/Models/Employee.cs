using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApiTest.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int DepId { get; set; }
        //[JsonIgnore]
        public virtual Department? Dep { get; set; } = null!;
    }
}
