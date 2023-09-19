using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Model
{
    /// <summary>
    /// Class <see cref="ProjectManager"/> represents a project manager in the firm, using multiple values
    /// </summary>
    internal class ProjectManager : Manager
    {
        private protected string _mail;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectManager"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of project manager</param>
        /// <param name="lastName">last name of the project manager</param>
        /// <param name="socialSecurityNumber">social security number of the project manager</param>
        /// <param name="phoneNumber">phone number of the project manager</param>
        /// <param name="mail">mail of the project manager</param>
        public ProjectManager(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string mail) : base(firstName, lastName, socialSecurityNumber, phoneNumber)
        {
            _mail = mail;
        }

        /// <summary>
        /// Represents a string of the object, by overriding af method which is common to all objects
        /// </summary>
        /// <returns>The overridden string</returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nMail: {_mail}";
        }
    }
}
