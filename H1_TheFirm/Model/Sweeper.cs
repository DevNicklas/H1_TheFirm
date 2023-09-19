using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Model
{
    /// <summary>
    /// Class <see cref="Sweeper"/> represents a sweeper in the firm, using multiple values
    /// </summary>
    internal class Sweeper : Employee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sweeper"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of employee</param>
        /// <param name="lastName">last name of employee</param>
        /// <param name="socialSecurityNumber">social security number of employee</param>
        internal Sweeper(string firstName, string lastName, string socialSecurityNumber) : base(firstName, lastName, socialSecurityNumber)
        {
        }
    }
}
