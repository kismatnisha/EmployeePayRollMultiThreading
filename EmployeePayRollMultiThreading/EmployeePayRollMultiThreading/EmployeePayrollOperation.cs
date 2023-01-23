using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultiThreading
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetail> employeeDetails = new List<EmployeeDetail>();
        public void AddEmployeeToPayroll(List<EmployeeDetail> listemp)
        {
            listemp.ForEach(empdata =>
            {
                Console.WriteLine("employee being added:" + empdata.EmployeeName);
                this.AddEmployeeToPayroll(empdata);
                Console.WriteLine("employee added:" + empdata.EmployeeName);
            });

        }
        private void AddEmployeeToPayroll(EmployeeDetail emp)
        {
            employeeDetails.Add(emp);
        }
    }
}