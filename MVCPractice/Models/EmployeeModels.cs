using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    [Table("tblEmployee")]
    public class EmployeeModels
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int DepartmentID { get; set; }
    }
}