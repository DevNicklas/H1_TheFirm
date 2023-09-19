using H1_TheFirm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.View
{
    /// <summary>
    /// Class <see cref="EmployeeGUI"/> represents all graphical about an employee
    /// </summary>
    internal class EmployeeGUI
    {
        /// <summary>
        /// Writes all information about an employee
        /// </summary>
        /// <param name="employee">the employee which will be shown</param>
        public void ShowEmployee(Employee employee)
        {
            Console.WriteLine("Medarbejder:");
            Console.WriteLine(employee.ToString());
            Console.WriteLine();
        }
    }
}
