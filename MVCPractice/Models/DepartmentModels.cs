﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    [Table("tblDepartment")]
    public class DepartmentModels 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<EmployeeModels> Employee {get; set;}
    }
}