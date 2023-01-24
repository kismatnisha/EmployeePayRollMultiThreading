using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks; 



namespace EmployeePayRollMultiThreading
{
    public class EmployeePayRollOperation
    {
        public List<EmployeeDetails> employeePayrollDetailList = new List<EmployeeDetails>();

        //UC 1
        public void addEmployeeToParollList(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToParollList(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
            });
            // Console.WriteLine(this.addEmployeeToParollList.ToString());
        }

     

        public void addEmployeeToParollList(EmployeeDetails employee)
        {
            employeePayrollDetailList.Add(employee);
        }
        public void addEmployeeToParollListWithThread(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Task Thread = new Task(() =>
                {
                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToParollList(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);


                });
                Thread.Start();

            });
              
        }
    }
}