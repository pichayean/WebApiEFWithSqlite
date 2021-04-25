using System.Collections.Generic;

namespace WebApiEFWithSqlite
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmployeesInProject> Employees { get; set; }
    }

}