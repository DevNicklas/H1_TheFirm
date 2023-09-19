using H1_TheFirm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.View
{
    /// <summary>
    /// Class <see cref="ProjectManagerGUI"/> represents all graphical about a project manager
    /// </summary>
    internal class ProjectManagerGUI
    {
        /// <summary>
        /// Writes all information about a project manager
        /// </summary>
        /// <param name="projectManager">the project manager which will be shown</param>
        public void ShowProjectManager(ProjectManager projectManager)
        {
            Console.WriteLine("Projektleder:");
            Console.WriteLine(projectManager.ToString());
            Console.WriteLine();
        }
    }
}
