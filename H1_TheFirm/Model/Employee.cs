using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Model
{
    /// <summary>
    /// Class <see cref="Employee"/> represents a employee in the firm, using multiple values
    /// </summary>
    internal class Employee
    {
        private protected string _firstName;
        private protected string _lastName;
        private protected string _socialSecurityNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of employee</param>
        /// <param name="lastName">last name of employee</param>
        /// <param name="socialSecurityNumber">social security number of employee</param>
        internal Employee(string firstName, string lastName, string socialSecurityNumber) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _socialSecurityNumber = socialSecurityNumber;
        }

        /// <summary>
        /// Represents a string of the object, by overriding af method which is common to all objects
        /// </summary>
        /// <returns>The overridden string</returns>
        public override string ToString()
        {
            return $"Navn: {_firstName} {_lastName}\nCPR-Nummer: {_socialSecurityNumber}";
        }
    }
}
