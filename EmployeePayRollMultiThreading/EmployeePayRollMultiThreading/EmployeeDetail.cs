using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultiThreading
{
    public class EmployeeDetail
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Phoneno { get; set; }
        public string Department { get; set; }

        public EmployeeDetail(int employeeID, string employeeName, string phoneno, string department)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Phoneno = phoneno;
            Department = department;
        }
    }
}