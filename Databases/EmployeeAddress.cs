
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEFWithSqlite
{
    public class EmployeeAddress
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
    }
}