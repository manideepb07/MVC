using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class EmployeeContext :DbContext
    {
        public DbSet<EmployeeModels> Employee { get; set; }
        public DbSet<DepartmentModels> Department { get; set; }
    }
}