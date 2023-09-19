using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Model
{
    /// <summary>
    /// Class <see cref="Manager"/> represents a manager in the firm, using multiple values
    /// </summary>
    internal class Manager : Employee
    {
        private protected string _phoneNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of manager</param>
        /// <param name="lastName">last name of manager</param>
        /// <param name="socialSecurityNumber">social security number of manager</param>
        /// <param name="phoneNumber">manager's phone number</param>
        internal Manager(string firstName, string lastName, string socialSecurityNumber, string phoneNumber) : base(firstName, lastName, socialSecurityNumber)
        {
            _phoneNumber = phoneNumber;
        }

        /// <summary>
        /// Represents a string of the object, by overriding af method which is common to all objects
        /// </summary>
        /// <returns>The overridden string</returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nTlf-nummer: {_phoneNumber}";
        }
    }
}
