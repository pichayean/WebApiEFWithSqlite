using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEFWithSqlite
{
    public class EmployeesInProject
    {
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
    }
}