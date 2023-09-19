using H1_TheFirm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.View
{
    /// <summary>
    /// Class <see cref="ManagerGUI"/> represents all graphical about a manager
    /// </summary>
    internal class ManagerGUI
    {
        /// <summary>
        /// Writes all information about a manager
        /// </summary>
        /// <param name="manager">the manager which will be shown</param>
        public void ShowManager(Manager manager)
        {
            Console.WriteLine("Manager:");
            Console.WriteLine(manager.ToString());
            Console.WriteLine();
        }
    }
}
