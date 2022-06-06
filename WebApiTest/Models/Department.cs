using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApiTest.Models
{
    public partial class Department
    {
        //public Department()
        //{
        //    Employees = new HashSet<Employee>();
        //}

        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        //[JsonIgnore]
        //public virtual ICollection<Employee> Employees { get; set; }
    }
}
